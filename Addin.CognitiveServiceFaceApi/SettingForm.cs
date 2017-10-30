using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Addin.CognitiveServiceFaceApi
{
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		public IDictionary<string, string> SettingValues { get; set; }

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			var setting = new SettingDictionaryUtil(this.SettingValues);
			setting.MediaTypeHeaderKeyValue = this.Txt_MediaTypeHeaderValue.Text;
			setting.OcpApimSubscriptionKeyValue = this.Txt_OcpApimSubscriptionKey.Text;
			setting.OcpApimSubscriptionValue = this.Txt_OcpApimSubscriptionValue.Text;
			setting.UriKeyValue = this.Txt_URI.Text;
			this.Close();
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			var setting = new SettingDictionaryUtil(this.SettingValues);
			this.Txt_MediaTypeHeaderValue.Text = setting.MediaTypeHeaderKeyValue;
			this.Txt_OcpApimSubscriptionKey.Text = setting.OcpApimSubscriptionKeyValue;
			this.Txt_OcpApimSubscriptionValue.Text = setting.OcpApimSubscriptionValue;
			this.Txt_URI.Text = setting.UriKeyValue;
		}
	}
}
