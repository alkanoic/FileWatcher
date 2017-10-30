using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addin.SendMailWithSendGrid
{
	public class SettingDictionaryUtil
	{
		public SettingDictionaryUtil(IDictionary<string, string> settingValues)
		{
			this.SettingValues = settingValues;
		}

		private IDictionary<string, string> _settingValues;
		public IDictionary<string, string> SettingValues
		{
			get
			{
				if (this._settingValues is null)
				{
					this._settingValues = new Dictionary<string, string>();
				}
				return this._settingValues;
			}
			set
			{
				this._settingValues = value;
			}
		}

		private const string AddToKey = "AddTo";
		public string AddToValue
		{
			get => this.SettingValues.Keys.Contains(AddToKey) ? this.SettingValues[AddToKey] : string.Empty;
			set => SettingValues[AddToKey] = value;
		}

		private const string FromKey = "From";
		public string FromValue
		{
			get => this.SettingValues.Keys.Contains(FromKey) ? this.SettingValues[FromKey] : string.Empty;
			set => SettingValues[FromKey] = value;
		}

		private const string SendGridApiKey = "SendGridApi";
		public string SendGridApiValue
		{
			get => this.SettingValues.Keys.Contains(SendGridApiKey) ? this.SettingValues[SendGridApiKey] : string.Empty;
			set => SettingValues[SendGridApiKey] = value;
		}

	}
}
