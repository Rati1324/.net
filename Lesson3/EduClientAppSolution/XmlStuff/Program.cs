using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlStuff {
	//[XmlRoot(ElementName = "Person")]
	public class Person {
		[XmlElement("FirstName")]
		public string FirstName { get; set; }
		[XmlElement("LastName")]
		public string LastName { get; set; }
	}

	//[XmlRoot(ElementName = "Student")]
	public class StudentDTO
    {      
        [XmlElement("Id")]
        public int Id { get; set; }      
        [XmlElement("FullName")]
        public string FullName { get; set; }
        [XmlElement("GPA")]
        public float GPA { get; set; }
    }

	class Program {
		public static void Serialize() {
			List<Person> P = new List<Person> {
				new Person() { FirstName = "john", LastName = "johnson" },
				new Person() { FirstName = "mike", LastName = "mikeson" }
			};

			XmlSerializer ser = new XmlSerializer(P.GetType());
			using (TextWriter w = new StreamWriter(@"C:/Users/rati/Documents/student.xml")) {
				ser.Serialize(w, P);
			}
		}

		public static T Deserialize<T>(string path, string rootElementName) where T : class, new() {
			T result = new T();
			XmlRootAttribute xmlRoot = new XmlRootAttribute();
			xmlRoot.ElementName = rootElementName;    
			xmlRoot.IsNullable = true;

			XmlSerializer deser = new XmlSerializer(typeof(T), xmlRoot);
			using (StreamReader r = new StreamReader(path)) {
				result = (T)deser.Deserialize(r);
			}
			return result;
		}

		static void Main(string[] args) {
			List<StudentDTO> S = Deserialize<List<StudentDTO>>("C:/Users/rati/Documents/students.xml", "ArrayOfStudentDTO");
			foreach (var item in S) {
				Console.WriteLine(item.FullName);
			}
		}
	}
}
