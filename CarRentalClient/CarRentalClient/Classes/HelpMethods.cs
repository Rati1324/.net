using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CarRentalClient.Classes {
	class HelpMethods {
		public static T Deserialize<T>(string xml, string rootElementName) where T : class, new() {
			T result = new T();
			XmlRootAttribute xmlRoot = new XmlRootAttribute();
			xmlRoot.ElementName = rootElementName;
			xmlRoot.IsNullable = true;

			XmlSerializer deser = new XmlSerializer(typeof(T), xmlRoot);
			using (TextReader r = new StringReader(xml)) {
				result = (T)deser.Deserialize(r);
			}
			return result;
		}

		public static XmlDocument Serialize<T>(T source) {
			var document = new XmlDocument { XmlResolver = null };
			var navigator = document.CreateNavigator();
			using (var writer = navigator.AppendChild()) {
				var serializer = new XmlSerializer(typeof(T));
				serializer.Serialize(writer, source);
			}
			return document;
		}
	}
}
