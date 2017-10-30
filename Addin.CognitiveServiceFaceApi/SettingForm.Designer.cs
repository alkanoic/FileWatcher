namespace Addin.CognitiveServiceFaceApi
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.Txt_OcpApimSubscriptionKey = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Txt_OcpApimSubscriptionValue = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Txt_URI = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Txt_MediaTypeHeaderValue = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Txt_OcpApimSubscriptionKey, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Txt_OcpApimSubscriptionValue, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.Txt_URI, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.Txt_MediaTypeHeaderValue, 1, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 237);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(261, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "OcpApimSubscriptionKey";
			// 
			// Txt_OcpApimSubscriptionKey
			// 
			this.Txt_OcpApimSubscriptionKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_OcpApimSubscriptionKey.Location = new System.Drawing.Point(294, 3);
			this.Txt_OcpApimSubscriptionKey.Name = "Txt_OcpApimSubscriptionKey";
			this.Txt_OcpApimSubscriptionKey.Size = new System.Drawing.Size(431, 31);
			this.Txt_OcpApimSubscriptionKey.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.Controls.Add(this.Btn_Save, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.Btn_Cancel, 2, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 318);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(728, 100);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// Btn_Save
			// 
			this.Btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_Save.Location = new System.Drawing.Point(245, 3);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(236, 44);
			this.Btn_Save.TabIndex = 0;
			this.Btn_Save.Text = "保存";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Btn_Cancel.Location = new System.Drawing.Point(487, 3);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(238, 44);
			this.Btn_Cancel.TabIndex = 1;
			this.Btn_Cancel.Text = "キャンセル";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(279, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "OcpApimSubscriptionValue";
			// 
			// Txt_OcpApimSubscriptionValue
			// 
			this.Txt_OcpApimSubscriptionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_OcpApimSubscriptionValue.Location = new System.Drawing.Point(294, 40);
			this.Txt_OcpApimSubscriptionValue.Name = "Txt_OcpApimSubscriptionValue";
			this.Txt_OcpApimSubscriptionValue.Size = new System.Drawing.Size(431, 31);
			this.Txt_OcpApimSubscriptionValue.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(242, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "URI";
			// 
			// Txt_URI
			// 
			this.Txt_URI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_URI.Location = new System.Drawing.Point(294, 77);
			this.Txt_URI.Name = "Txt_URI";
			this.Txt_URI.Size = new System.Drawing.Size(431, 31);
			this.Txt_URI.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(242, 24);
			this.label4.TabIndex = 7;
			this.label4.Text = "MediaTypeHeaderValue";
			// 
			// Txt_MediaTypeHeaderValue
			// 
			this.Txt_MediaTypeHeaderValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Txt_MediaTypeHeaderValue.Location = new System.Drawing.Point(294, 114);
			this.Txt_MediaTypeHeaderValue.Name = "Txt_MediaTypeHeaderValue";
			this.Txt_MediaTypeHeaderValue.Size = new System.Drawing.Size(431, 31);
			this.Txt_MediaTypeHeaderValue.TabIndex = 8;
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 418);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "SettingForm";
			this.Text = "SettingForm";
			this.Load += new System.EventHandler(this.SettingForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button Btn_Save;
		private System.Windows.Forms.Button Btn_Cancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Txt_OcpApimSubscriptionKey;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Txt_OcpApimSubscriptionValue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Txt_URI;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Txt_MediaTypeHeaderValue;
	}
}