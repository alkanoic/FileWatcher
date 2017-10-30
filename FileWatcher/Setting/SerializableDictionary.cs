using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FileWatcher.Setting
{
	public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
	{
		public XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(XmlReader reader)
		{
			bool isEmpty = reader.IsEmptyElement;
			reader.Read();
			if (isEmpty)
			{
				return;
			}

			XmlSerializer serializer = new XmlSerializer(typeof(KeyValue));
			while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
			{
				KeyValue kv = serializer.Deserialize(reader) as KeyValue;
				if (kv != null) Add(kv.Key, kv.Value);
			}
			reader.Read();
		}

		public void WriteXml(System.Xml.XmlWriter writer)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(KeyValue));
			foreach (var key in Keys)
			{
				serializer.Serialize(writer, new KeyValue(key, this[key]));
			}
		}

		public class KeyValue
		{
			public KeyValue()
			{
			}
			public KeyValue(TKey key, TValue value)
			{
				Key = key; Value = value;
			}

			public TKey Key { get; set; }
			public TValue Value { get; set; }
		}
	}
}
