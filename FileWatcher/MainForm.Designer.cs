namespace FileWatcher
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.Trv_AddinWatcher = new System.Windows.Forms.TreeView();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.Btn_AddWatcher = new System.Windows.Forms.Button();
			this.Btn_DeleteWatcher = new System.Windows.Forms.Button();
			this.Tlp_AddinTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.Label1 = new System.Windows.Forms.Label();
			this.Btn_SaveSetting = new System.Windows.Forms.Button();
			this.Btn_AddinSetting = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Txt_FileFilter = new System.Windows.Forms.TextBox();
			this.Chk_WatchSubDirectory = new System.Windows.Forms.CheckBox();
			this.Chkl_NotifyFilter = new System.Windows.Forms.CheckedListBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Chk_Enable = new System.Windows.Forms.CheckBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Txt_WatcherName = new System.Windows.Forms.TextBox();
			this.Lbl_AddinName = new System.Windows.Forms.Label();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Chk_Error = new System.Windows.Forms.CheckBox();
			this.Chk_Renamed = new System.Windows.Forms.CheckBox();
			this.Chk_Deleted = new System.Windows.Forms.CheckBox();
			this.Chk_Changed = new System.Windows.Forms.CheckBox();
			this.Chk_Created = new System.Windows.Forms.CheckBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Txt_WatchDirectoryPath = new System.Windows.Forms.TextBox();
			this.Btn_DirectoryDialog = new System.Windows.Forms.Button();
			this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.Tlp_AddinTableLayoutPanel.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// SplitContainer1
			// 
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer1.Name = "SplitContainer1";
			// 
			// SplitContainer1.Panel1
			// 
			this.SplitContainer1.Panel1.Controls.Add(this.TableLayoutPanel4);
			// 
			// SplitContainer1.Panel2
			// 
			this.SplitContainer1.Panel2.Controls.Add(this.Tlp_AddinTableLayoutPanel);
			this.SplitContainer1.Size = new System.Drawing.Size(1303, 814);
			this.SplitContainer1.SplitterDistance = 434;
			this.SplitContainer1.TabIndex = 6;
			// 
			// TableLayoutPanel4
			// 
			this.TableLayoutPanel4.ColumnCount = 1;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 434F));
			this.TableLayoutPanel4.Controls.Add(this.Trv_AddinWatcher, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.TableLayoutPanel5, 0, 1);
			this.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 2;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.TableLayoutPanel4.Size = new System.Drawing.Size(434, 814);
			this.TableLayoutPanel4.TabIndex = 0;
			// 
			// Trv_AddinWatcher
			// 
			this.Trv_AddinWatcher.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Trv_AddinWatcher.Location = new System.Drawing.Point(3, 3);
			this.Trv_AddinWatcher.Name = "Trv_AddinWatcher";
			this.Trv_AddinWatcher.Size = new System.Drawing.Size(428, 748);
			this.Trv_AddinWatcher.TabIndex = 0;
			// 
			// TableLayoutPanel5
			// 
			this.TableLayoutPanel5.ColumnCount = 2;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayoutPanel5.Controls.Add(this.Btn_AddWatcher, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.Btn_DeleteWatcher, 1, 0);
			this.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel5.Location = new System.Drawing.Point(3, 757);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.TableLayoutPanel5.Size = new System.Drawing.Size(428, 54);
			this.TableLayoutPanel5.TabIndex = 5;
			// 
			// Btn_AddWatcher
			// 
			this.Btn_AddWatcher.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_AddWatcher.Location = new System.Drawing.Point(3, 3);
			this.Btn_AddWatcher.Name = "Btn_AddWatcher";
			this.Btn_AddWatcher.Size = new System.Drawing.Size(208, 48);
			this.Btn_AddWatcher.TabIndex = 0;
			this.Btn_AddWatcher.Text = "追加";
			this.Btn_AddWatcher.UseVisualStyleBackColor = true;
			// 
			// Btn_DeleteWatcher
			// 
			this.Btn_DeleteWatcher.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_DeleteWatcher.Location = new System.Drawing.Point(217, 3);
			this.Btn_DeleteWatcher.Name = "Btn_DeleteWatcher";
			this.Btn_DeleteWatcher.Size = new System.Drawing.Size(208, 48);
			this.Btn_DeleteWatcher.TabIndex = 1;
			this.Btn_DeleteWatcher.Text = "削除";
			this.Btn_DeleteWatcher.UseVisualStyleBackColor = true;
			// 
			// Tlp_AddinTableLayoutPanel
			// 
			this.Tlp_AddinTableLayoutPanel.ColumnCount = 2;
			this.Tlp_AddinTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.Tlp_AddinTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Label1, 0, 2);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Btn_SaveSetting, 1, 8);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Btn_AddinSetting, 0, 8);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Label2, 0, 4);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Txt_FileFilter, 1, 4);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Chk_WatchSubDirectory, 1, 3);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Chkl_NotifyFilter, 1, 5);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Label3, 0, 5);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Chk_Enable, 1, 7);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Label4, 0, 6);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Label5, 0, 0);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Label6, 0, 1);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Txt_WatcherName, 1, 1);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Lbl_AddinName, 1, 0);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.TableLayoutPanel1, 1, 6);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.Label7, 0, 7);
			this.Tlp_AddinTableLayoutPanel.Controls.Add(this.TableLayoutPanel2, 1, 2);
			this.Tlp_AddinTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tlp_AddinTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.Tlp_AddinTableLayoutPanel.Name = "Tlp_AddinTableLayoutPanel";
			this.Tlp_AddinTableLayoutPanel.RowCount = 9;
			this.Tlp_AddinTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.Tlp_AddinTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.Tlp_AddinTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.Tlp_AddinTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.Tlp_AddinTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.Tlp_AddinTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
			this.Tlp_AddinTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
			this.Tlp_AddinTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.Tlp_AddinTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.Tlp_AddinTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.Tlp_AddinTableLayoutPanel.Size = new System.Drawing.Size(865, 814);
			this.Tlp_AddinTableLayoutPanel.TabIndex = 0;
			// 
			// Label1
			// 
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(98, 113);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(158, 24);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "監視ディレクトリ";
			// 
			// Btn_SaveSetting
			// 
			this.Btn_SaveSetting.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_SaveSetting.Location = new System.Drawing.Point(262, 713);
			this.Btn_SaveSetting.Name = "Btn_SaveSetting";
			this.Btn_SaveSetting.Size = new System.Drawing.Size(600, 98);
			this.Btn_SaveSetting.TabIndex = 15;
			this.Btn_SaveSetting.Text = "保存";
			this.Btn_SaveSetting.UseVisualStyleBackColor = true;
			// 
			// Btn_AddinSetting
			// 
			this.Btn_AddinSetting.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_AddinSetting.Location = new System.Drawing.Point(3, 713);
			this.Btn_AddinSetting.Name = "Btn_AddinSetting";
			this.Btn_AddinSetting.Size = new System.Drawing.Size(253, 98);
			this.Btn_AddinSetting.TabIndex = 14;
			this.Btn_AddinSetting.Text = "アドイン設定";
			this.Btn_AddinSetting.UseVisualStyleBackColor = true;
			// 
			// Label2
			// 
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(92, 213);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(164, 24);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "ファイルフィルター";
			// 
			// Txt_FileFilter
			// 
			this.Txt_FileFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_FileFilter.Location = new System.Drawing.Point(262, 203);
			this.Txt_FileFilter.Name = "Txt_FileFilter";
			this.Txt_FileFilter.Size = new System.Drawing.Size(600, 31);
			this.Txt_FileFilter.TabIndex = 8;
			// 
			// Chk_WatchSubDirectory
			// 
			this.Chk_WatchSubDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Chk_WatchSubDirectory.AutoSize = true;
			this.Chk_WatchSubDirectory.Location = new System.Drawing.Point(262, 161);
			this.Chk_WatchSubDirectory.Name = "Chk_WatchSubDirectory";
			this.Chk_WatchSubDirectory.Size = new System.Drawing.Size(242, 28);
			this.Chk_WatchSubDirectory.TabIndex = 6;
			this.Chk_WatchSubDirectory.Text = "サブディレクトリを含む";
			this.Chk_WatchSubDirectory.UseVisualStyleBackColor = true;
			// 
			// Chkl_NotifyFilter
			// 
			this.Chkl_NotifyFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Chkl_NotifyFilter.FormattingEnabled = true;
			this.Chkl_NotifyFilter.Items.AddRange(new object[] {
            "ファイル名",
            "ディレクトリ名",
            "属性",
            "サイズ",
            "最終書込日付",
            "最終読込日付",
            "作成日付",
            "セキュリティ設定"});
			this.Chkl_NotifyFilter.Location = new System.Drawing.Point(262, 253);
			this.Chkl_NotifyFilter.Name = "Chkl_NotifyFilter";
			this.Chkl_NotifyFilter.Size = new System.Drawing.Size(600, 234);
			this.Chkl_NotifyFilter.TabIndex = 10;
			// 
			// Label3
			// 
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(111, 358);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(145, 24);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "通知フィルター";
			// 
			// Chk_Enable
			// 
			this.Chk_Enable.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Chk_Enable.AutoSize = true;
			this.Chk_Enable.Location = new System.Drawing.Point(262, 671);
			this.Chk_Enable.Name = "Chk_Enable";
			this.Chk_Enable.Size = new System.Drawing.Size(90, 28);
			this.Chk_Enable.TabIndex = 13;
			this.Chk_Enable.Text = "有効";
			this.Chk_Enable.UseVisualStyleBackColor = true;
			// 
			// Label4
			// 
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(198, 563);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(58, 24);
			this.Label4.TabIndex = 11;
			this.Label4.Text = "機能";
			// 
			// Label5
			// 
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(152, 13);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(104, 24);
			this.Label5.TabIndex = 0;
			this.Label5.Text = "アドイン名";
			// 
			// Label6
			// 
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(174, 63);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(82, 24);
			this.Label6.TabIndex = 2;
			this.Label6.Text = "監視名";
			// 
			// Txt_WatcherName
			// 
			this.Txt_WatcherName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_WatcherName.Location = new System.Drawing.Point(262, 53);
			this.Txt_WatcherName.Name = "Txt_WatcherName";
			this.Txt_WatcherName.Size = new System.Drawing.Size(600, 31);
			this.Txt_WatcherName.TabIndex = 3;
			// 
			// Lbl_AddinName
			// 
			this.Lbl_AddinName.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Lbl_AddinName.AutoSize = true;
			this.Lbl_AddinName.Location = new System.Drawing.Point(262, 13);
			this.Lbl_AddinName.Name = "Lbl_AddinName";
			this.Lbl_AddinName.Size = new System.Drawing.Size(0, 24);
			this.Lbl_AddinName.TabIndex = 1;
			// 
			// TableLayoutPanel1
			// 
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel1.Controls.Add(this.Chk_Error, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Chk_Renamed, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Chk_Deleted, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Chk_Changed, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Chk_Created, 0, 0);
			this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel1.Location = new System.Drawing.Point(262, 493);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 3;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(600, 164);
			this.TableLayoutPanel1.TabIndex = 16;
			// 
			// Chk_Error
			// 
			this.Chk_Error.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Chk_Error.AutoSize = true;
			this.Chk_Error.Location = new System.Drawing.Point(3, 122);
			this.Chk_Error.Name = "Chk_Error";
			this.Chk_Error.Size = new System.Drawing.Size(97, 28);
			this.Chk_Error.TabIndex = 4;
			this.Chk_Error.Text = "エラー";
			this.Chk_Error.UseVisualStyleBackColor = true;
			// 
			// Chk_Renamed
			// 
			this.Chk_Renamed.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Chk_Renamed.AutoSize = true;
			this.Chk_Renamed.Location = new System.Drawing.Point(106, 67);
			this.Chk_Renamed.Name = "Chk_Renamed";
			this.Chk_Renamed.Size = new System.Drawing.Size(138, 28);
			this.Chk_Renamed.TabIndex = 3;
			this.Chk_Renamed.Text = "名前変更";
			this.Chk_Renamed.UseVisualStyleBackColor = true;
			// 
			// Chk_Deleted
			// 
			this.Chk_Deleted.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Chk_Deleted.AutoSize = true;
			this.Chk_Deleted.Location = new System.Drawing.Point(3, 67);
			this.Chk_Deleted.Name = "Chk_Deleted";
			this.Chk_Deleted.Size = new System.Drawing.Size(90, 28);
			this.Chk_Deleted.TabIndex = 2;
			this.Chk_Deleted.Text = "削除";
			this.Chk_Deleted.UseVisualStyleBackColor = true;
			// 
			// Chk_Changed
			// 
			this.Chk_Changed.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Chk_Changed.AutoSize = true;
			this.Chk_Changed.Location = new System.Drawing.Point(106, 13);
			this.Chk_Changed.Name = "Chk_Changed";
			this.Chk_Changed.Size = new System.Drawing.Size(90, 28);
			this.Chk_Changed.TabIndex = 1;
			this.Chk_Changed.Text = "更新";
			this.Chk_Changed.UseVisualStyleBackColor = true;
			// 
			// Chk_Created
			// 
			this.Chk_Created.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Chk_Created.AutoSize = true;
			this.Chk_Created.Location = new System.Drawing.Point(3, 13);
			this.Chk_Created.Name = "Chk_Created";
			this.Chk_Created.Size = new System.Drawing.Size(90, 28);
			this.Chk_Created.TabIndex = 0;
			this.Chk_Created.Text = "作成";
			this.Chk_Created.UseVisualStyleBackColor = true;
			// 
			// Label7
			// 
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(198, 673);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(58, 24);
			this.Label7.TabIndex = 17;
			this.Label7.Text = "有効";
			// 
			// TableLayoutPanel2
			// 
			this.TableLayoutPanel2.ColumnCount = 2;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.TableLayoutPanel2.Controls.Add(this.Txt_WatchDirectoryPath, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Btn_DirectoryDialog, 1, 0);
			this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel2.Location = new System.Drawing.Point(262, 103);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(600, 44);
			this.TableLayoutPanel2.TabIndex = 18;
			// 
			// Txt_WatchDirectoryPath
			// 
			this.Txt_WatchDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_WatchDirectoryPath.Location = new System.Drawing.Point(3, 3);
			this.Txt_WatchDirectoryPath.Name = "Txt_WatchDirectoryPath";
			this.Txt_WatchDirectoryPath.Size = new System.Drawing.Size(494, 31);
			this.Txt_WatchDirectoryPath.TabIndex = 5;
			// 
			// Btn_DirectoryDialog
			// 
			this.Btn_DirectoryDialog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_DirectoryDialog.Location = new System.Drawing.Point(500, 0);
			this.Btn_DirectoryDialog.Margin = new System.Windows.Forms.Padding(0);
			this.Btn_DirectoryDialog.Name = "Btn_DirectoryDialog";
			this.Btn_DirectoryDialog.Size = new System.Drawing.Size(100, 44);
			this.Btn_DirectoryDialog.TabIndex = 6;
			this.Btn_DirectoryDialog.Text = "選択";
			this.Btn_DirectoryDialog.UseVisualStyleBackColor = true;
			// 
			// FolderBrowserDialog
			// 
			this.FolderBrowserDialog.Description = "監視するフォルダを選択してください";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1303, 814);
			this.Controls.Add(this.SplitContainer1);
			this.Name = "MainForm";
			this.Text = "FileWatcher";
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
			this.SplitContainer1.ResumeLayout(false);
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.Tlp_AddinTableLayoutPanel.ResumeLayout(false);
			this.Tlp_AddinTableLayoutPanel.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.SplitContainer SplitContainer1;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
		internal System.Windows.Forms.TreeView Trv_AddinWatcher;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel5;
		internal System.Windows.Forms.Button Btn_AddWatcher;
		internal System.Windows.Forms.Button Btn_DeleteWatcher;
		private System.Windows.Forms.TableLayoutPanel Tlp_AddinTableLayoutPanel;
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Button Btn_SaveSetting;
		internal System.Windows.Forms.Button Btn_AddinSetting;
		internal System.Windows.Forms.Label Label2;
		private System.Windows.Forms.TextBox Txt_FileFilter;
		internal System.Windows.Forms.CheckBox Chk_WatchSubDirectory;
		internal System.Windows.Forms.CheckedListBox Chkl_NotifyFilter;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.CheckBox Chk_Enable;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		private System.Windows.Forms.TextBox Txt_WatcherName;
		internal System.Windows.Forms.Label Lbl_AddinName;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
		internal System.Windows.Forms.CheckBox Chk_Error;
		internal System.Windows.Forms.CheckBox Chk_Renamed;
		internal System.Windows.Forms.CheckBox Chk_Deleted;
		internal System.Windows.Forms.CheckBox Chk_Changed;
		internal System.Windows.Forms.CheckBox Chk_Created;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
		private System.Windows.Forms.TextBox Txt_WatchDirectoryPath;
		internal System.Windows.Forms.Button Btn_DirectoryDialog;
		internal System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
	}
}

