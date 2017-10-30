using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addin.SendMailWithSendGrid
{
	public partial class SettingForm : Form
	{
		public IDictionary<string, string> SettingValues { get; set; }

		public SettingForm()
		{
			InitializeComponent();
		}

		private void Btn_OK_Click(object sender, EventArgs e)
		{
			var setting = new SettingDictionaryUtil(this.SettingValues);
			setting.SendGridApiValue = this.Txt_SendGridApi.Text;
			setting.AddToValue = this.Txt_SendTo.Text;
			setting.FromValue = this.Txt_SendFrom.Text;
			this.Close();
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			var setting = new SettingDictionaryUtil(this.SettingValues);
			this.Txt_SendGridApi.Text = setting.SendGridApiValue;
			this.Txt_SendFrom.Text = setting.FromValue;
			this.Txt_SendTo.Text = setting.AddToValue;
		}
	}
}
