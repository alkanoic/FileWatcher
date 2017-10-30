using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addin.CognitiveServiceFaceApi
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

		private const string OcpApimSubscriptionKey = "OcpApimSubscriptionKey";
		public string OcpApimSubscriptionKeyValue
		{
			get => this.SettingValues.Keys.Contains(OcpApimSubscriptionKey) ? this.SettingValues[OcpApimSubscriptionKey] : string.Empty;
			set => SettingValues[OcpApimSubscriptionKey] = value;
		}

		private const string OcpApimSubscriptionValueKey = "OcpApimSubscriptionValue";
		public string OcpApimSubscriptionValue
		{
			get => this.SettingValues.Keys.Contains(OcpApimSubscriptionValueKey) ? this.SettingValues[OcpApimSubscriptionValueKey] : string.Empty;
			set => SettingValues[OcpApimSubscriptionValueKey] = value;
		}

		private const string UriKey = "UriKey";
		public string UriKeyValue
		{
			get => this.SettingValues.Keys.Contains(UriKey) ? this.SettingValues[UriKey] : string.Empty;
			set => SettingValues[UriKey] = value;
		}

		private const string MediaTypeHeaderKey = "MediaTypeHeaderKey";
		public string MediaTypeHeaderKeyValue
		{
			get => this.SettingValues.Keys.Contains(MediaTypeHeaderKey) ? this.SettingValues[MediaTypeHeaderKey] : string.Empty;
			set => SettingValues[MediaTypeHeaderKey] = value;
		}

	}
}
