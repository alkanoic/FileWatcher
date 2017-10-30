namespace Addin.SendMailWithSendGrid
{
	partial class SettingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Txt_SendGridApi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Txt_SendFrom = new System.Windows.Forms.TextBox();
			this.Txt_SendTo = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Btn_OK = new System.Windows.Forms.Button();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.Txt_SendGridApi, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.Txt_SendFrom, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.Txt_SendTo, 1, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(901, 151);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(210, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "送信元メールアドレス";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(134, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "SendGridApi";
			// 
			// Txt_SendGridApi
			// 
			this.Txt_SendGridApi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_SendGridApi.Location = new System.Drawing.Point(273, 3);
			this.Txt_SendGridApi.Name = "Txt_SendGridApi";
			this.Txt_SendGridApi.Size = new System.Drawing.Size(625, 31);
			this.Txt_SendGridApi.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(210, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "送信先メールアドレス";
			// 
			// Txt_SendFrom
			// 
			this.Txt_SendFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_SendFrom.Location = new System.Drawing.Point(273, 40);
			this.Txt_SendFrom.Name = "Txt_SendFrom";
			this.Txt_SendFrom.Size = new System.Drawing.Size(625, 31);
			this.Txt_SendFrom.TabIndex = 3;
			// 
			// Txt_SendTo
			// 
			this.Txt_SendTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_SendTo.Location = new System.Drawing.Point(273, 77);
			this.Txt_SendTo.Name = "Txt_SendTo";
			this.Txt_SendTo.Size = new System.Drawing.Size(625, 31);
			this.Txt_SendTo.TabIndex = 5;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Controls.Add(this.Btn_OK, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Btn_Cancel, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 252);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(901, 100);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// Btn_OK
			// 
			this.Btn_OK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_OK.Location = new System.Drawing.Point(303, 3);
			this.Btn_OK.Name = "Btn_OK";
			this.Btn_OK.Size = new System.Drawing.Size(294, 44);
			this.Btn_OK.TabIndex = 0;
			this.Btn_OK.Text = "OK";
			this.Btn_OK.UseVisualStyleBackColor = true;
			this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_Cancel.Location = new System.Drawing.Point(603, 3);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(295, 44);
			this.Btn_Cancel.TabIndex = 1;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(901, 352);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "SettingForm";
			this.Text = "SettingForm";
			this.Load += new System.EventHandler(this.SettingForm_Load);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button Btn_OK;
		private System.Windows.Forms.Button Btn_Cancel;
		private System.Windows.Forms.TextBox Txt_SendGridApi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Txt_SendFrom;
		private System.Windows.Forms.TextBox Txt_SendTo;
	}
}