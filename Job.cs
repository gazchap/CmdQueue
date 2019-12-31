using System;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;

namespace CmdQueue
{
	[Serializable]
	[XmlRoot("CmdQueueJob")]
	public class Job
	{

		[XmlElement("Command")]
		public string Command { get; set; }

		[XmlElement("Arguments")]
		public string Arguments { get; set; }

        [XmlElement( "StartDirectory")]
        public string StartDirectory { get; set; }

		[XmlElement( "Name" )]
		public string Name { get; set; }

        public void SetCommandFromString( string commandString, string argumentsString = "" ) {
            ParseCommandLine( commandString );
            if ( argumentsString != "" ) {
                Arguments = argumentsString + " " + Arguments;
                Arguments = Arguments.Trim();
            }
        }

        public void ParseCommandLine( string commandString ) {
            string[] parts = SplitCommand( commandString );

            Command = parts[0];
            Arguments = "";
            for( int index = 1; index < parts.Length; index++ ) {
                if ( parts[index].Contains(" ") ) {
                    parts[index] = "\"" + parts[index] + "\"";
                }
                Arguments += parts[index] + " ";
            }
            Arguments = Arguments.Trim();
        }

        public Process GetProcess() {
            Process process = new Process();
            process.StartInfo.FileName = Command;
            process.StartInfo.Arguments = Arguments;
            if ( StartDirectory != "" ) {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WorkingDirectory = StartDirectory;
            }
            process.EnableRaisingEvents = true;
            return process;
        }

        private string[] SplitCommand( string CommandToSplit ) {
            int numberOfArgs;
            IntPtr ptrToSplitArgs;
            string[] splitArgs;

            ptrToSplitArgs = CommandLineToArgvW( CommandToSplit, out numberOfArgs );
            if ( ptrToSplitArgs == IntPtr.Zero )
                throw new ArgumentException( "Unable to split argument.",
                  new Win32Exception() );
            try {
                splitArgs = new string[numberOfArgs];
                for ( int i = 0; i < numberOfArgs; i++ )
                    splitArgs[i] = Marshal.PtrToStringUni(
                        Marshal.ReadIntPtr( ptrToSplitArgs, i * IntPtr.Size ) );
                return splitArgs;
            } finally {
                LocalFree( ptrToSplitArgs );
            }
        }

        [DllImport( "shell32.dll", SetLastError = true )]
        static extern IntPtr CommandLineToArgvW(
            [MarshalAs( UnmanagedType.LPWStr )] string lpCmdLine,
            out int pNumArgs );

        [DllImport( "kernel32.dll" )]
        static extern IntPtr LocalFree( IntPtr hMem );

        public override string ToString() {
			if ( Name != "" ) {
				return Name;
			} else {
				return Command + " " + Arguments;
			}
		}
	}
}
