using Newtonsoft.Json;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CmdQueue
{
	static class Program
	{
		public static JobQueue JobQueue = new JobQueue();

		public static string[] PassedArguments;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) {
			PassedArguments = args;

			bool isNewInstance;
			Mutex mutex = new Mutex( true, "com.gazchap.cmdqueue", out isNewInstance );
			if ( isNewInstance ) {
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault( false );
				Application.Run( new frmMain() );

                mutex.ReleaseMutex();
			} else {
                string windowTitle = "CmdQueue";

                // Find the window with the name of the main form
                IntPtr ptrWnd = NativeMethods.FindWindow( null, windowTitle );
                if ( ptrWnd == IntPtr.Zero ) {
                    MessageBox.Show( String.Format( "No window found with the title {0}.", windowTitle ),
                    "CmdQueue Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                } else {
                    IntPtr ptrCopyData = IntPtr.Zero;
                    try {
                        string argsString = JsonConvert.SerializeObject(args);

                        // Create the data structure and fill with data
                        NativeMethods.COPYDATASTRUCT copyData = new NativeMethods.COPYDATASTRUCT();
                        copyData.dwData = new IntPtr( 2 );    // Just a number to identify the data type
                        copyData.cbData = argsString.Length + 1;  // One extra byte for the \0 character
                        copyData.lpData = Marshal.StringToHGlobalAnsi( argsString );

                        // Allocate memory for the data and copy
                        ptrCopyData = Marshal.AllocCoTaskMem( Marshal.SizeOf( copyData ) );
                        Marshal.StructureToPtr( copyData, ptrCopyData, false );

                        // Send the message
                        NativeMethods.SendMessage( ptrWnd, NativeMethods.WM_COPYDATA, IntPtr.Zero, ptrCopyData );
                    } catch ( Exception ex ) {
                        MessageBox.Show( ex.ToString(), "CmdQueue Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error );
                    } finally {
                        // Free the allocated memory after the control has been returned
                        if ( ptrCopyData != IntPtr.Zero )
                            Marshal.FreeCoTaskMem( ptrCopyData );
                    }
                }
            }
		}
	}
}
