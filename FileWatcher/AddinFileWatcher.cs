using FileWatcher.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Addin;

namespace FileWatcher
{
	class AddinFileWatcher : Addin.IWatcher
	{
		private LoggerImpl _logger = new LoggerImpl();

		private System.IO.FileSystemWatcher _watcher = new System.IO.FileSystemWatcher();

		public String Filter
		{
			get => _watcher.Filter;
			set => _watcher.Filter = value;
		}

		public bool IncludeSubdirectories
		{
			get => _watcher.IncludeSubdirectories;
			set => _watcher.IncludeSubdirectories = value;
		}

		public int InternalBufferSize
		{
			get => _watcher.InternalBufferSize;
			set => _watcher.InternalBufferSize = value;
		}

		public System.IO.NotifyFilters NotifyFilter
		{
			get => _watcher.NotifyFilter;
			set => _watcher.NotifyFilter = value;
		}

		public string Path
		{
			get => _watcher.Path;
			set => _watcher.Path = value;
		}

		public bool EnableCreated;
		public bool EnableChanged;
		public bool EnableDeleted;
		public bool EnableRenamed;
		public bool EnableError;
		public bool Enable;

		public Addin.IAddin AddinImpl;

		public string WatcherName;
		public int DisplaySequence;

		string IWatcher.WatcherName
		{
			get => this.WatcherName;
			set => this.WatcherName = value;
		}

		public void Activate()
		{
			if (this.Enable == false) return;

			_watcher.Created += this.CreatedEvent;
			_watcher.Changed += this.ChangedEvent;
			_watcher.Deleted += this.DeletedEvent;
			_watcher.Renamed += this.RenamedEvent;
			_watcher.Error += this.ErrorEvent;

			_watcher.EnableRaisingEvents = true;
		}

		public void Deactivate()
		{
			_watcher.Created -= this.CreatedEvent;
			_watcher.Changed -= this.ChangedEvent;
			_watcher.Deleted -= this.DeletedEvent;
			_watcher.Renamed -= this.RenamedEvent;
			_watcher.Error -= this.ErrorEvent;

			_watcher.EnableRaisingEvents = false;
		}

		private async void ChangedEvent(object sender, System.IO.FileSystemEventArgs e)
		{
			if (this.AddinImpl.HasChanged == false) return;
			if (this.EnableChanged == false) return;

			_logger.Info($"{AddinImpl.AddinName}:{WatcherName}:{e.ChangeType}:{e.FullPath}");
			await this.AddinImpl.ChangedMethodAsync(e);
		}

		private async void CreatedEvent(object sender, System.IO.FileSystemEventArgs e)
		{
			if (this.AddinImpl.HasCreated == false) return;
			if (this.EnableCreated == false) return;

			_logger.Info($"{AddinImpl.AddinName}:{WatcherName}:{e.ChangeType}:{e.FullPath}");
			await this.AddinImpl.CreatedMethodAsync(e);
		}

		private async void DeletedEvent(object sender, System.IO.FileSystemEventArgs e)
		{
			if (this.AddinImpl.HasDeleted == false) return;
			if (this.EnableDeleted == false) return;

			_logger.Info($"{AddinImpl.AddinName}:{WatcherName}:{e.ChangeType}:{e.FullPath}");
			await this.AddinImpl.DeletedMethodAsync(e);
		}

		private async void RenamedEvent(object sender, System.IO.RenamedEventArgs e)
		{
			if (this.AddinImpl.HasRenamed == false) return;
			if (this.EnableRenamed == false) return;

			_logger.Info($"{AddinImpl.AddinName}:{WatcherName}:{e.ChangeType}:{e.OldName}:{e.Name}");
			await this.AddinImpl.RenamedMethodAsync(e);
		}

		private async void ErrorEvent(object sender, System.IO.ErrorEventArgs e)
		{
			_logger.Error($"{AddinImpl.AddinName}:{WatcherName}");
			_logger.Error(e.GetException());
			if (this.AddinImpl.HasError == false) return;
			if (this.EnableError == false) return;

			await this.AddinImpl.ErrorMethodAsync(e);
		}
	}
}
