using System.Collections.Generic;
using System.Threading.Tasks;

namespace Addin
{
	public interface IAddin
	{
		string AddinName { get; }

		IWatcher Watcher { get; set; }

		Task CreatedMethodAsync(System.IO.FileSystemEventArgs e);

		Task ChangedMethodAsync(System.IO.FileSystemEventArgs e);

		Task DeletedMethodAsync(System.IO.FileSystemEventArgs e);

		Task RenamedMethodAsync(System.IO.RenamedEventArgs e);

		Task ErrorMethodAsync(System.IO.ErrorEventArgs e);

		ILogger Logger { get; set; }

		void ShowSettingForm();

		IDictionary<string, string> SettingValues { get; set; }

		bool HasSetting { get; }

		bool HasCreated { get; }

		bool HasChanged { get; }

		bool HasDeleted { get; }

		bool HasRenamed { get; }

		bool HasError { get; }
	}
}
