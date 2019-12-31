using System;
using System.IO;
using System.Windows.Forms;

namespace CmdQueue
{
	public partial class frmJobDetails : Form
	{
		private Job selectedJob;

		public frmJobDetails( int selectedJobIndex = -1 ) {
			InitializeComponent();

			openFileDialog.Filter = "Programs|*.exe|Batch files|*.bat;*.cmd|All files|*.*";

			if ( selectedJobIndex > -1 && Program.JobQueue.HasIndex( selectedJobIndex ) ) {
				selectedJob = Program.JobQueue.Jobs[selectedJobIndex];

				txtCommand.Text = selectedJob.Command;
				txtArguments.Text = selectedJob.Arguments;
				txtName.Text = selectedJob.Name;
				txtStartIn.Text = selectedJob.StartDirectory;
			}
		}

		private void btnSave_Click( object sender, EventArgs e ) {
			if ( txtStartIn.Text != "" && !Directory.Exists( txtStartIn.Text ) ) {
				MessageBox.Show( "The Start In directory specified does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			selectedJob.SetCommandFromString( txtCommand.Text, txtArguments.Text );
			selectedJob.Name = txtName.Text;
			selectedJob.StartDirectory = txtStartIn.Text;
			Program.JobQueue.SaveQueue();

			Close();
		}

		private void btnCancel_Click( object sender, EventArgs e ) {
			Close();
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
			if ( txtCommand.Text != "" ) {
				openFileDialog.FileName = Path.GetFileName( txtCommand.Text );
				openFileDialog.InitialDirectory = Path.GetDirectoryName( txtCommand.Text );
			} else {
				openFileDialog.FileName = "";
			}

			if ( openFileDialog.ShowDialog() == DialogResult.OK ) {
				txtCommand.Text = openFileDialog.FileName;
			}
		}

	}
}
