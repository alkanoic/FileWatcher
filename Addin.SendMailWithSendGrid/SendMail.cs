using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addin.SendMailWithSendGrid
{
	[Export(typeof(IAddin))]
	public class SendMail : Addin.IAddin
	{
		public string AddinName => "Send Grid Mail";

		public ILogger Logger { get; set; }
		public IDictionary<string, string> SettingValues { get; set; }

		public bool HasSetting => true;

		public bool HasCreated => true;

		public bool HasChanged => true;

		public bool HasDeleted => true;

		public bool HasRenamed => true;

		public bool HasError => false;

		public IWatcher Watcher { get; set; }

		private async Task SendMainOnSendGrid(FileSystemEventArgs e)
		{
			var setting = new SettingDictionaryUtil(this.SettingValues);

			var myMessage = new SendGrid.Helpers.Mail.SendGridMessage();
			myMessage.AddTo(setting.AddToValue);
			myMessage.From = new SendGrid.Helpers.Mail.EmailAddress(setting.FromValue);
			myMessage.Subject = $"{this.AddinName}:{this.Watcher.WatcherName}";
			myMessage.PlainTextContent = $"{e.ChangeType}:{e.FullPath}";

			var transportWeb = new SendGrid.SendGridClient(setting.SendGridApiValue);
			await transportWeb.SendEmailAsync(myMessage);
		}

		public async Task ChangedMethodAsync(FileSystemEventArgs e)
		{
			await SendMainOnSendGrid(e);
		}

		public async Task CreatedMethodAsync(FileSystemEventArgs e)
		{
			await SendMainOnSendGrid(e);
		}

		public async Task DeletedMethodAsync(FileSystemEventArgs e)
		{
			await SendMainOnSendGrid(e);
		}

		public Task ErrorMethodAsync(ErrorEventArgs e)
		{
			throw new NotImplementedException();
		}

		public async Task RenamedMethodAsync(RenamedEventArgs e)
		{
			await SendMainOnSendGrid(e);
		}

		public void ShowSettingForm()
		{
			using (var f = new SettingForm())
			{
				if (this.SettingValues is null)
				{
					this.SettingValues = new Dictionary<string, string>();
				}
				f.SettingValues = this.SettingValues;
				f.ShowDialog();
				this.SettingValues = f.SettingValues;
			}
		}
	}
}
