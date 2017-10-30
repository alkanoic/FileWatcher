using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcher.Setting
{
	public class Watcher
	{
		public int DisplaySequence;

		public string AddinClass;

		public SerializableDictionary<string, string> AddinSettings;

		public string WatcherName;

		public string WatchDirectory;

		public bool WatchSubDirectory;

		public string FileFilter;

		public System.IO.NotifyFilters NotifyFilter;

		public bool EnableCreated;

		public bool EnableChanged;

		public bool EnableDeleted;

		public bool EnableRenamed;

		public bool EnableError;

		public bool Enable;

	}
}
