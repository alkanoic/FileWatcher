using FileWatcher.Logger;
using FileWatcher.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Registration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWatcher
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			this.Load += this.MainForm_Load;
			this.FormClosing += this.MainForm_Closing;
			this.Btn_AddWatcher.Click += this.Btn_AddWatcher_Click;
			this.Btn_DeleteWatcher.Click += this.Btn_DeleteWatcher_Click;
			this.Btn_DirectoryDialog.Click += this.Btn_DirectoryDialog_Click;
			this.Btn_AddinSetting.Click += this.Btn_AddinSetting_Click;
			this.Btn_SaveSetting.Click += this.Btn_SaveSetting_Click;
			this.Trv_AddinWatcher.AfterSelect += this.Trv_AddinWatcher_AfterSelect;

		}

		private LoggerImpl _logger = new LoggerImpl();

		private List<AddinFileWatcher> _watcherList = new List<AddinFileWatcher>();
		private AddinFileWatcher CurrentWatcher { get; set; }

		private Addin.IAddin CurrentAddin
		{
			get
			{
				if (CurrentWatcher == null)
				{
					return null;
				}
				return CurrentWatcher.AddinImpl;
			}
		}

		[ImportMany(typeof(Addin.IAddin))]
		public IEnumerable<Addin.IAddin> AddIns { get; set; }

		public enum ChklNotifyFilter
		{
			FileName = 0,
			DirectoryName,
			Attributes,
			Size,
			LastWrite,
			LastAccess,
			CreationTime,
			Security
		}

		private void ReadAddinAssemblies()
		{
			var catalog = new DirectoryCatalog(System.IO.Path.Combine(
				System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
				"AddIns"));
			var container = new CompositionContainer(catalog);

			try
			{
				container.ComposeParts(this);
				SettingUtil.Addins = this.AddIns;

				foreach (Addin.IAddin Addin in SettingUtil.Addins)
				{
					this.Trv_AddinWatcher.Nodes.Add(Addin.AddinName);
				}

			}
			catch (ReflectionTypeLoadException ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private bool ValidateSaveSetting()
		{

			if (string.IsNullOrEmpty(this.Txt_WatcherName.Text))
			{
				MessageBox.Show("監視名を入力してください。");
				Txt_WatcherName.Focus();
				return false;
			}


			if (this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.FileName) == false && this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.DirectoryName) == false && this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.Attributes) == false && this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.Size) == false && this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.LastWrite) == false && this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.LastAccess) == false && this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.CreationTime) == false && this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.Security) == false)
			{
				MessageBox.Show("通知フィルターを1つ以上選択してください。");
				return false;
			}

			return true;
		}

		private void SaveSetting()
		{
			Setting.Setting setting = SettingUtil.ConvertToSetting(this._watcherList);

			SettingXmlSerializer serializer = new SettingXmlSerializer(typeof(Setting.Setting));
			serializer.Serialize(Properties.Settings.Default.SettingFileName, setting);
		}

		private void LoadSetting()
		{
			if (System.IO.File.Exists(Properties.Settings.Default.SettingFileName) == false)
				return;

			SettingXmlSerializer serializer = new SettingXmlSerializer(typeof(Setting.Setting));
			Setting.Setting setting = serializer.Deserialize(Properties.Settings.Default.SettingFileName);

			foreach (var w in setting.WatcherList)
			{
				AddinFileWatcher watcher = SettingUtil.ConvertToAddinFileWatcher(w);
				if (watcher.AddinImpl == null)
					continue;

				watcher.AddinImpl.Logger = this._logger;
				watcher.AddinImpl.Watcher = watcher;
				this._watcherList.Add(watcher);
			}

			this.SyncWatcherListAndForms();
			this.ActivateWatcherList();
		}

		private void ActivateWatcherList()
		{
			foreach (var w in this._watcherList)
			{
				w.Activate();
			}
			this.SetTrvColor();
		}

		private void SetTrvColor()
		{
			foreach (var w in this._watcherList)
			{
				int index = this.GetTrv_AddinWatcherNodeByAddinName(w.AddinImpl.AddinName);
				foreach (TreeNode x in this.Trv_AddinWatcher.Nodes[index].Nodes)
				{
					if (x.Text == w.WatcherName)
					{
						if (w.Enable)
						{
							x.ForeColor = Color.Red;
						}
						else
						{
							x.ForeColor = Color.Black;
						}
					}
				}
			}
		}

		private void SyncWatcherListAndForms()
		{
			foreach (var w in this._watcherList)
			{
				int index = this.GetTrv_AddinWatcherNodeByAddinName(w.AddinImpl.AddinName);
				this.Trv_AddinWatcher.Nodes[index].Nodes.Add(w.WatcherName);
			}
		}

		private int GetTrv_AddinWatcherNodeByAddinName(string addinName)
		{
			foreach (TreeNode n in this.Trv_AddinWatcher.Nodes)
			{
				if (n.FullPath == addinName && n.Parent == null)
				{
					return n.Index;
				}
			}
			return 0;
		}

		private AddinFileWatcher GetWatcherListIndexByNodeName(string nodeName)
		{
			foreach (var w in this._watcherList)
			{
				if (w.WatcherName == nodeName)
				{
					return w;
				}
			}
			return null;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.ReadAddinAssemblies();
			SettingUtil.Addins = this.AddIns;
			this.LoadSetting();
		}

		private void MainForm_Closing(object sender, CancelEventArgs e)
		{
			foreach (var w in this._watcherList)
			{
				w.Deactivate();
			}
		}

		private void Btn_AddWatcher_Click(object sender, EventArgs e)
		{
			if (this.Trv_AddinWatcher.SelectedNode.Parent != null)
				return;

			string newWatcherName = $"new{Trv_AddinWatcher.SelectedNode.Text}";

			this.Trv_AddinWatcher.SelectedNode.Nodes.Add(newWatcherName);
			this.Trv_AddinWatcher.SelectedNode.Expand();

			AddinFileWatcher filewatcher = new AddinFileWatcher();
			filewatcher.AddinImpl = SettingUtil.GetAddinInstanceByAddinName(Trv_AddinWatcher.SelectedNode.Text);
			filewatcher.AddinImpl.Logger = this._logger;
			filewatcher.AddinImpl.Watcher = filewatcher;
			filewatcher.WatcherName = newWatcherName;
			this._watcherList.Add(filewatcher);

			this.SaveSetting();
		}

		private void Btn_DeleteWatcher_Click(object sender, EventArgs e)
		{
			if (this.Trv_AddinWatcher.SelectedNode.Parent == null)
				return;

			this._watcherList.Remove(this.CurrentWatcher);
			this.Trv_AddinWatcher.SelectedNode.Remove();
			this.SaveSetting();
		}

		private void Btn_DirectoryDialog_Click(object sender, EventArgs e)
		{
			if (System.IO.Directory.Exists(this.Txt_WatchDirectoryPath.Text))
			{
				this.FolderBrowserDialog.SelectedPath = this.Txt_WatchDirectoryPath.Text;
			}
			if (DialogResult.OK == this.FolderBrowserDialog.ShowDialog())
			{
				this.Txt_WatchDirectoryPath.Text = this.FolderBrowserDialog.SelectedPath;
			}
		}

		private void Btn_AddinSetting_Click(object sender, EventArgs e)
		{
			this.CurrentWatcher.AddinImpl.ShowSettingForm();
		}

		private void Btn_SaveSetting_Click(object sender, EventArgs e)
		{
			if (this.ValidateSaveSetting() == false)
				return;

			this.CurrentWatcher.WatcherName = this.Txt_WatcherName.Text;
			this.CurrentWatcher.Path = this.Txt_WatchDirectoryPath.Text;
			this.CurrentWatcher.IncludeSubdirectories = this.Chk_WatchSubDirectory.Checked;
			this.CurrentWatcher.Filter = this.Txt_FileFilter.Text;

			this.CurrentWatcher.NotifyFilter = System.IO.NotifyFilters.Security;
			if (this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.FileName))
			{
				this.CurrentWatcher.NotifyFilter = this.CurrentWatcher.NotifyFilter | System.IO.NotifyFilters.FileName;
			}
			if (this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.DirectoryName))
			{
				this.CurrentWatcher.NotifyFilter = this.CurrentWatcher.NotifyFilter | System.IO.NotifyFilters.DirectoryName;
			}
			if (this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.Attributes))
			{
				this.CurrentWatcher.NotifyFilter = this.CurrentWatcher.NotifyFilter | System.IO.NotifyFilters.Attributes;
			}
			if (this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.Size))
			{
				this.CurrentWatcher.NotifyFilter = this.CurrentWatcher.NotifyFilter | System.IO.NotifyFilters.Size;
			}
			if (this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.LastWrite))
			{
				this.CurrentWatcher.NotifyFilter = this.CurrentWatcher.NotifyFilter | System.IO.NotifyFilters.LastWrite;
			}
			if (this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.LastAccess))
			{
				this.CurrentWatcher.NotifyFilter = this.CurrentWatcher.NotifyFilter | System.IO.NotifyFilters.LastAccess;
			}
			if (this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.CreationTime))
			{
				this.CurrentWatcher.NotifyFilter = this.CurrentWatcher.NotifyFilter | System.IO.NotifyFilters.CreationTime;
			}
			if (this.Chkl_NotifyFilter.GetItemChecked((int)ChklNotifyFilter.Security))
			{
				this.CurrentWatcher.NotifyFilter = this.CurrentWatcher.NotifyFilter | System.IO.NotifyFilters.Security;
			}
			else
			{
				this.CurrentWatcher.NotifyFilter = this.CurrentWatcher.NotifyFilter & ~System.IO.NotifyFilters.Security;
			}

			this.CurrentWatcher.EnableCreated = this.Chk_Created.Checked;
			this.CurrentWatcher.EnableChanged = this.Chk_Changed.Checked;
			this.CurrentWatcher.EnableDeleted = this.Chk_Deleted.Checked;
			this.CurrentWatcher.EnableRenamed = this.Chk_Renamed.Checked;
			this.CurrentWatcher.EnableError = this.Chk_Error.Checked;
			this.CurrentWatcher.Enable = this.Chk_Enable.Checked;

			this.Trv_AddinWatcher.SelectedNode.Text = Txt_WatcherName.Text;
			this.SaveSetting();

			this.CurrentWatcher.Deactivate();
			this.CurrentWatcher.Activate();
			this.SetTrvColor();
		}

		private void Trv_AddinWatcher_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.CurrentWatcher = this.GetWatcherListIndexByNodeName(e.Node.Text);

			if (this.CurrentWatcher == null)
			{
				Tlp_AddinTableLayoutPanel.Enabled = false;
				this.Btn_AddWatcher.Enabled = true;
				this.Btn_DeleteWatcher.Enabled = false;
			}
			else
			{
				Tlp_AddinTableLayoutPanel.Enabled = true;
				this.Btn_AddWatcher.Enabled = false;
				this.Btn_DeleteWatcher.Enabled = true;

				this.Lbl_AddinName.Text = this.CurrentAddin.AddinName;
				this.Txt_WatcherName.Text = this.CurrentWatcher.WatcherName;
				this.Txt_WatchDirectoryPath.Text = this.CurrentWatcher.Path;
				this.Chk_WatchSubDirectory.Checked = this.CurrentWatcher.IncludeSubdirectories;
				this.Txt_FileFilter.Text = this.CurrentWatcher.Filter;

				this.Chkl_NotifyFilter.SetItemChecked((int)ChklNotifyFilter.FileName, this.CurrentWatcher.NotifyFilter.HasFlag(System.IO.NotifyFilters.FileName));
				this.Chkl_NotifyFilter.SetItemChecked((int)ChklNotifyFilter.DirectoryName, this.CurrentWatcher.NotifyFilter.HasFlag(System.IO.NotifyFilters.DirectoryName));
				this.Chkl_NotifyFilter.SetItemChecked((int)ChklNotifyFilter.Attributes, this.CurrentWatcher.NotifyFilter.HasFlag(System.IO.NotifyFilters.Attributes));
				this.Chkl_NotifyFilter.SetItemChecked((int)ChklNotifyFilter.Size, this.CurrentWatcher.NotifyFilter.HasFlag(System.IO.NotifyFilters.Size));
				this.Chkl_NotifyFilter.SetItemChecked((int)ChklNotifyFilter.LastWrite, this.CurrentWatcher.NotifyFilter.HasFlag(System.IO.NotifyFilters.LastWrite));
				this.Chkl_NotifyFilter.SetItemChecked((int)ChklNotifyFilter.LastAccess, this.CurrentWatcher.NotifyFilter.HasFlag(System.IO.NotifyFilters.LastAccess));
				this.Chkl_NotifyFilter.SetItemChecked((int)ChklNotifyFilter.CreationTime, this.CurrentWatcher.NotifyFilter.HasFlag(System.IO.NotifyFilters.CreationTime));
				this.Chkl_NotifyFilter.SetItemChecked((int)ChklNotifyFilter.Security, this.CurrentWatcher.NotifyFilter.HasFlag(System.IO.NotifyFilters.Security));

				this.Chk_Created.Enabled = this.CurrentAddin.HasCreated;
				this.Chk_Changed.Enabled = this.CurrentAddin.HasChanged;
				this.Chk_Deleted.Enabled = this.CurrentAddin.HasDeleted;
				this.Chk_Renamed.Enabled = this.CurrentAddin.HasRenamed;
				this.Chk_Error.Enabled = this.CurrentAddin.HasError;
				this.Chk_Created.Checked = this.CurrentWatcher.EnableCreated;
				this.Chk_Changed.Checked = this.CurrentWatcher.EnableChanged;
				this.Chk_Deleted.Checked = this.CurrentWatcher.EnableDeleted;
				this.Chk_Renamed.Checked = this.CurrentWatcher.EnableRenamed;
				this.Chk_Error.Checked = this.CurrentWatcher.EnableError;

				this.Btn_AddinSetting.Enabled = this.CurrentAddin.HasSetting;

				this.Chk_Enable.Checked = this.CurrentWatcher.Enable;
			}

		}

	}

}
