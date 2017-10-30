using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcher.Setting
{
	class SettingXmlSerializer
	{
		private System.Xml.Serialization.XmlSerializer _serializer = new System.Xml.Serialization.XmlSerializer(typeof(Setting));
		private Type type;

		public SettingXmlSerializer(Type type)
		{
			this.type = type;
		}

		public void Serialize(string fileName, Setting setting)
		{
			using(var stream = new System.IO.StreamWriter(fileName)){
				_serializer.Serialize(stream, setting);
			}
		}

		public Setting Deserialize(string fileName)
		{
			using (var stream = new System.IO.StreamReader(fileName))
			{
				return (Setting)_serializer.Deserialize(stream);
			}
		}
	}
}
