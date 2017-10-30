using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addin.ToastNotification
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
			setting.DisplayTimeValue = this.Num_DisplayTime.Value;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			var setting = new SettingDictionaryUtil(this.SettingValues);
			this.Num_DisplayTime.Value = setting.DisplayTimeValue;
		}
	}
}
