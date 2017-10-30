using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addin.ToastNotification
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

		public const string DisplayTimeKey = "DisplayTime";

		public decimal DisplayTimeValue
		{
			get
			{
				if (! this.SettingValues.Keys.Contains(DisplayTimeKey))
				{
					return 3000;
				}
				return decimal.Parse(this.SettingValues[DisplayTimeKey]);
			}
			set
			{
				SettingValues[DisplayTimeKey] = value.ToString();
			}
		}

		public int DisplayTimeValueInt
		{
			get
			{
				return (int)this.DisplayTimeValue;
			}
		}

	}
}
