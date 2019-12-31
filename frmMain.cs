using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.IO;

namespace CmdQueue
{
	public partial class frmMain : Form
	{
		private bool queueStarted = false;
		private bool processInProgress = false;

		public frmMain() {
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;

			StringCollection commandHistory = AppSettings.Instance.CommandHistory;
			if ( commandHistory != null ) {
				foreach( string command in commandHistory ) {
					cmbNewCommand.Items.Add( command );
				}
			}

			openFileDialog.Filter = "Programs|*.exe|Batch files|*.bat;*.cmd|All files|*.*";

			lblStatus.Text = "Waiting...";
			lblVersion.Text = "v" + Application.ProductVersion;

			RefreshListbox();
			ProcessArguments( Program.PassedArguments );
		}

		public void ProcessArguments( string[] args ) {
			// check for passed arguments
			if ( args.Length > 0 ) {
				string argument = "";
				string nextArgument = "";
				bool skipNext = false;
				string newCommand = "";
				string newName = "";
				string newStartIn = "";
				bool doStartQueue = false;
				bool doStopQueue = false;
				bool doAdd = false;
				for( int index = 0; index < args.Length; index++ ) {
					skipNext = false;

					argument = args[index].ToUpper();
					if ( args.Length > index + 1 ) {
						nextArgument = args[index + 1];
					} else {
						nextArgument = "";
					}

					if ( argument == "/NAME" ) {
						newName = nextArgument;
						skipNext = true;
					}

					if ( argument == "/STARTIN" ) {
						newStartIn = nextArgument;
						skipNext = true;
					}

					if ( argument == "/START" ) {
						doStartQueue = true;
						doStopQueue = false;
					}

					if ( argument == "/STOP" ) {
						doStopQueue = true;
						doStartQueue = false;
					}

					if ( argument == "/ADD" ) {
						// all of the other arguments after this one form the command
						newCommand = "";
						if ( nextArgument != "" ) {
							for ( int index2 = index + 1; index2 < args.Length; index2++ ) {
								string thisArgument = args[index2];
								if ( thisArgument.Contains(" ") ) {
									thisArgument = "\"" + thisArgument + "\"";
								}
								newCommand += thisArgument + " ";
							}
							doAdd = true;
							break;
						}
					}

					if ( skipNext ) {
						index++;
					}
				}

				if ( doAdd && newCommand != "" ) {
					AddNewJob( newCommand, newName, newStartIn );
				}

				if ( ( doStartQueue && !queueStarted ) || ( doStopQueue && queueStarted ) ) {
					RefreshListbox();
					StartStopQueue();
				}
			}
		}

		protected override void WndProc( ref Message m ) {
			if ( m.Msg == NativeMethods.WM_COPYDATA ) {
				// Extract the file name
				NativeMethods.COPYDATASTRUCT copyData =
				(NativeMethods.COPYDATASTRUCT)Marshal.PtrToStructure
				( m.LParam, typeof( NativeMethods.COPYDATASTRUCT ) );
				int dataType = (int)copyData.dwData;
				if ( dataType == 2 ) {
					string argsString = Marshal.PtrToStringAnsi( copyData.lpData );

					string[] args = JsonConvert.DeserializeObject<string[]>( argsString );
					if ( args.Length > 0 ) {
						ProcessArguments( args );
					}
				} else {
					MessageBox.Show( String.Format( "Unrecognized data type = {0}.",
					dataType ), "CmdQueue Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				}
			} else {
				base.WndProc( ref m );
			}
		}

		private void btnAdd_Click( object sender, EventArgs e ) {

			string Command = cmbNewCommand.Text;
			string Name = txtName.Text;
			string StartIn = txtStartIn.Text;

			if ( Command.Trim() != "" ) {
				bool addResult = AddNewJob( Command, Name, StartIn );
				if ( addResult ) {
					if ( !cmbNewCommand.Items.Contains( Command ) ) {
						cmbNewCommand.Items.Add( Command );
						StringCollection commandHistory = new StringCollection();
						foreach ( object command in cmbNewCommand.Items ) {
							commandHistory.Add( command.ToString() );

							// limit to 20 last used commands
							if ( commandHistory.Count > 20 ) {
								break;
							}
						}
						AppSettings.Instance.CommandHistory = null;
						AppSettings.Instance.CommandHistory = commandHistory;
						AppSettings.Instance.Save();
					}

					cmbNewCommand.Text = "";
					txtName.Text = "";
					txtStartIn.Text = "";
					cmbNewCommand.Focus();
				}
			}
		}

		private bool AddNewJob( string Command, string Name = "", string StartIn = "" ) {
			if ( StartIn != "" && !Directory.Exists( StartIn ) ) {
				MessageBox.Show( "The Start In directory specified does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return false;
			}
			Job job = new Job();
			job.SetCommandFromString( Command );
			job.StartDirectory = StartIn;
			job.Name = Name;

			Program.JobQueue.AddItem( job );
			RefreshListbox();
			return true;
		}

		private void btnDelete_Click( object sender, EventArgs e ) {
			ListBox.SelectedIndexCollection indices = lstCurrentQueue.SelectedIndices;
			foreach( int index in indices ) {
				Program.JobQueue.RemoveItem( index );
			}
			RefreshListbox();
		}
		private void btnMoveUp_Click( object sender, EventArgs e ) {
			ListBox.SelectedIndexCollection indices = lstCurrentQueue.SelectedIndices;
			foreach ( int index in indices ) {
				Program.JobQueue.MoveItemUp( index );
			}
			RefreshListbox( indices, -1 );
		}
		private void btnMoveDown_Click( object sender, EventArgs e ) {
			ListBox.SelectedIndexCollection indices = lstCurrentQueue.SelectedIndices;
			foreach ( int index in indices ) {
				Program.JobQueue.MoveItemDown( index );
			}
			RefreshListbox( indices, 1 );
		}

		private void lstCurrentQueue_DoubleClick( object sender, EventArgs e ) {
			if ( lstCurrentQueue.SelectedIndex != null ) {
				frmJobDetails frm = new frmJobDetails( lstCurrentQueue.SelectedIndex );
				frm.ShowDialog();
				RefreshListbox();
			}
		}
		private void lstCurrentQueue_SelectedIndexChanged( object sender, EventArgs e ) {
			if ( queueStarted && lstCurrentQueue.SelectedIndex == 0 ) {
				lstCurrentQueue.SelectedIndex = -1;
			}
		}


		private void RefreshListbox( ListBox.SelectedIndexCollection indices = null, int offset = 0 ) {
			lstCurrentQueue.DataSource = null;
			lstCurrentQueue.DataSource = Program.JobQueue.Jobs;
			lstCurrentQueue.Refresh();

			if ( indices != null && offset != 0 ) {
				int[] array = indices.Cast<int>().ToArray();

				for ( int index = 0; index < lstCurrentQueue.Items.Count; index++ ) {
					lstCurrentQueue.SetSelected( index, false );
				}

				foreach( int index in array ) {
					if ( index > -1 && index < lstCurrentQueue.Items.Count ) {
						lstCurrentQueue.SetSelected( index + offset, true );
					}
				}
			}
		}

		private void btnStart_Click( object sender, EventArgs e ) {
			StartStopQueue();
		}

		private void StartStopQueue() {
			if ( !queueStarted ) {
				queueStarted = true;
				btnStart.Text = "Stop";
				ProcessNextJob();
			} else {
				queueStarted = false;
				btnStart.Text = "Start";
			}
		}

		private void ProcessNextJob() {
			if ( Program.JobQueue.Jobs.Count > 0 ) {
				if ( !processInProgress && Program.JobQueue.HasIndex( 0 ) ) {
					Job job = Program.JobQueue.Jobs[0];
					Process process = Program.JobQueue.GetProcess( 0 );
					process.Exited += new EventHandler( handleProcessExited );
					Program.JobQueue.RemoveItem( 0 );
					RefreshListbox();

					try {
						process.Start();
						processInProgress = true;
						lblStatus.Text = "Running: " + process.StartInfo.FileName + " " + process.StartInfo.Arguments;
					} catch ( Exception e ) {
						ProcessNextJob();
					}
				}
			} else {
				queueStarted = false;
				btnStart.Text = "Start";
				lblStatus.Text = "";
			}
		}

		private void handleProcessExited( object sender, EventArgs e ) {
			processInProgress = false;
			if ( queueStarted ) {
				ProcessNextJob();
			} else {
				lblStatus.Text = "";
			}
		}

		private void frmMain_Load( object sender, EventArgs e ) {
			NativeMethods.CHANGEFILTERSTRUCT changeFilter = new NativeMethods.CHANGEFILTERSTRUCT();
			changeFilter.size = (uint)Marshal.SizeOf( changeFilter );
			changeFilter.info = 0;
			if ( !NativeMethods.ChangeWindowMessageFilterEx
			( this.Handle, NativeMethods.WM_COPYDATA,
			NativeMethods.ChangeWindowMessageFilterExAction.Allow, ref changeFilter ) ) {
				int error = Marshal.GetLastWin32Error();
				MessageBox.Show( String.Format( "The error {0} occurred.", error ) );
			}
		}

		private void lblWebURL_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e ) {
			Process.Start( "https://gazchap.com/cmdqueue/" );
		}

		private void btnBrowseStartIn_Click( object sender, EventArgs e ) {
			if ( txtStartIn.Text != "" && Directory.Exists( txtStartIn.Text ) ) {
				folderBrowserDialog.SelectedPath = txtStartIn.Text;
			}
			if ( folderBrowserDialog.ShowDialog() == DialogResult.OK ) {
				txtStartIn.Text = folderBrowserDialog.SelectedPath;
			}
		}

		private void btnOpenFile_Click( object sender, EventArgs e ) {
			if ( cmbNewCommand.Text != "" ) {
				openFileDialog.FileName = Path.GetFileName( cmbNewCommand.Text );
				openFileDialog.InitialDirectory = Path.GetDirectoryName( cmbNewCommand.Text );
			} else {
				openFileDialog.FileName = "";
			}

			if ( openFileDialog.ShowDialog() == DialogResult.OK ) {
				cmbNewCommand.Text = openFileDialog.FileName;
			}
		}
	}
}
