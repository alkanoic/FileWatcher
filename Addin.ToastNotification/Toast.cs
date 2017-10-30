using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addin.ToastNotification
{
	[Export(typeof(IAddin))]
	public class Toast : Addin.IAddin
	{
		public string AddinName => "Toast Notifivation";

		public ILogger Logger { get; set; }
		public IDictionary<string, string> SettingValues { get; set; }

		public bool HasSetting => true;

		public bool HasCreated => true;

		public bool HasChanged => true;

		public bool HasDeleted => true;

		public bool HasRenamed => true;

		public bool HasError => false;

		public IWatcher Watcher { get; set; }

		private async Task FileSystemBalloonMethod(string displayText)
		{
			await Task.Factory.StartNew(() =>
			{
				using (NotifyIcon ni = new NotifyIcon(new System.ComponentModel.Container()))
				{
					ni.BalloonTipTitle = $"{this.AddinName}:{Watcher.WatcherName}";
					ni.BalloonTipText = displayText;
					ni.Icon = System.Drawing.SystemIcons.Application;
					ni.BalloonTipIcon = ToolTipIcon.Info;
					ni.Visible = true;
					var setting = new SettingDictionaryUtil(this.SettingValues);
					ni.ShowBalloonTip(setting.DisplayTimeValueInt);
				}
			});
		}

		public async Task ChangedMethodAsync(FileSystemEventArgs e)
		{
			await this.FileSystemBalloonMethod($"Changed:{e.FullPath}");
		}

		public async Task CreatedMethodAsync(FileSystemEventArgs e)
		{
			await this.FileSystemBalloonMethod($"Created:{e.FullPath}");
		}

		public async Task DeletedMethodAsync(FileSystemEventArgs e)
		{
			await this.FileSystemBalloonMethod($"Deleted:{e.FullPath}");
		}

		public Task ErrorMethodAsync(ErrorEventArgs e)
		{
			throw new NotImplementedException();
		}

		public async Task RenamedMethodAsync(RenamedEventArgs e)
		{
			await this.FileSystemBalloonMethod($"Renamed:{e.OldName} To:{e.Name}");
		}

		public void ShowSettingForm()
		{
			using (var sf = new SettingForm())
			{
				if (this.SettingValues is null)
				{
					this.SettingValues = new Dictionary<string, string>();
				}
				sf.SettingValues = this.SettingValues;
				sf.ShowDialog();
				this.SettingValues = sf.SettingValues;
			}
		}
	}
}
