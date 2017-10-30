
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using FileWatcher.Setting;
using System.Linq;

namespace FileWatcher.Setting
{
	class SettingUtil
	{
		public static IEnumerable<Addin.IAddin> Addins;
		public static Setting ConvertToSetting(IEnumerable<AddinFileWatcher> watchers)
		{

			Setting setting = new Setting();

			setting.WatcherList = new List<Watcher>();
			foreach (var w in watchers)
			{
				setting.WatcherList.Add(ConvertToSetting(w));
			}

			return setting;

		}

		public static Watcher ConvertToSetting(AddinFileWatcher addinFileWatcher)
		{
			Watcher watcher = new Watcher();
			watcher.AddinClass = addinFileWatcher.AddinImpl.GetType().AssemblyQualifiedName;
			watcher.DisplaySequence = addinFileWatcher.DisplaySequence;
			watcher.Enable = addinFileWatcher.Enable;
			watcher.FileFilter = addinFileWatcher.Filter;
			watcher.NotifyFilter = addinFileWatcher.NotifyFilter;
			watcher.WatchDirectory = addinFileWatcher.Path;
			watcher.WatcherName = addinFileWatcher.WatcherName;
			watcher.WatchSubDirectory = addinFileWatcher.IncludeSubdirectories;
			watcher.EnableChanged = addinFileWatcher.EnableChanged;
			watcher.EnableCreated = addinFileWatcher.EnableCreated;
			watcher.EnableDeleted = addinFileWatcher.EnableDeleted;
			watcher.EnableRenamed = addinFileWatcher.EnableRenamed;
			watcher.EnableError = addinFileWatcher.EnableError;
			if (addinFileWatcher.AddinImpl.SettingValues != null)
			{
				SerializableDictionary<string, string> sv = new SerializableDictionary<string, string>();
				foreach (var key in addinFileWatcher.AddinImpl.SettingValues.Keys)
				{
					sv.Add(key, addinFileWatcher.AddinImpl.SettingValues[key]);
				}
				watcher.AddinSettings = sv;
			}

			return watcher;

		}

		public static AddinFileWatcher ConvertToAddinFileWatcher(Watcher watcher)
		{
			AddinFileWatcher addinFileWatcher = new AddinFileWatcher();
			Addin.IAddin addin = GetAddinInstance(watcher.AddinClass);
			if (addin == null) return addinFileWatcher;
			addinFileWatcher.AddinImpl = addin;
			addinFileWatcher.DisplaySequence = watcher.DisplaySequence;
			addinFileWatcher.Enable = watcher.Enable;
			addinFileWatcher.Filter = watcher.FileFilter;
			addinFileWatcher.NotifyFilter = watcher.NotifyFilter;
			addinFileWatcher.WatcherName = watcher.WatcherName;
			addinFileWatcher.IncludeSubdirectories = watcher.WatchSubDirectory;
			addinFileWatcher.EnableChanged = watcher.EnableChanged;
			addinFileWatcher.EnableCreated = watcher.EnableCreated;
			addinFileWatcher.EnableDeleted = watcher.EnableDeleted;
			addinFileWatcher.EnableRenamed = watcher.EnableRenamed;
			addinFileWatcher.EnableError = watcher.EnableError;
			addinFileWatcher.AddinImpl.SettingValues = watcher.AddinSettings;
			if (System.IO.Directory.Exists(watcher.WatchDirectory))
			{
				addinFileWatcher.Path = watcher.WatchDirectory;
			}
			else
			{
				addinFileWatcher.Enable = false;
			}

			return addinFileWatcher;
		}

		public static Addin.IAddin GetAddinInstance(string assembyName)
		{
			return Addins.Where(a => a.GetType().AssemblyQualifiedName == assembyName).FirstOrDefault();
		}

		public static Addin.IAddin GetAddinInstanceByAddinName(string addinName)
		{
			return Addins.Where(a => a.AddinName == addinName).First();
		}
	}
}
