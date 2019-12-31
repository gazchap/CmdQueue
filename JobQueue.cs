using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace CmdQueue
{
	class JobQueue
	{
		public List<Job> Jobs { get; set; }

		public JobQueue() {
			LoadQueue();
		}

		public void AddItem( Job job ) {
			Jobs.Add( job );
			SaveQueue();
		}

		public void RemoveItem( Job job ) {
			if ( Jobs.Contains( job ) ) {
				Jobs.Remove( job );
				SaveQueue();
			}
		}

		public void RemoveItem( int index ) {
			if ( HasIndex( index ) ) {
				Jobs.RemoveAt( index );
				SaveQueue();
			}
		}

		public void MoveItemUp( int index ) {
			if ( index > 0 && HasIndex( index ) ) {
				Job item = Jobs[index];
				Jobs.RemoveAt( index );
				Jobs.Insert( index - 1, item );
				SaveQueue();
			}
		}

		public void MoveItemDown( int index ) {
			if ( index < Jobs.Count - 1 && HasIndex( index ) ) {
				Job item = Jobs[index];
				Jobs.RemoveAt( index );
				Jobs.Insert( index + 1, item );
				SaveQueue();
			}
		}

		public bool HasIndex( int index ) {
			if ( index >= 0 && Jobs.Count > index && Jobs.ElementAt( index ) != null ) {
				return true;
			}
			return false;
		}

		public Process GetProcess( Job job ) {
			return job.GetProcess();
		}

		public Process GetProcess( int index ) {
			if ( HasIndex( index ) ) {
				Job job = Jobs[index];
				return GetProcess( job );
			}
			return null;
		}

		private void LoadQueue() {
			Jobs = AppSettings.Instance.CurrentQueue;
			if ( Jobs == null ) Jobs = new List<Job>();
			SaveQueue();
		}

		public void SaveQueue() {
			AppSettings.Instance.CurrentQueue = null;
			AppSettings.Instance.CurrentQueue = Jobs;
			AppSettings.Instance.Save();
		}
	}
}
