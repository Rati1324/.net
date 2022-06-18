using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarRentalClient.Classes {
	[Serializable]
	public class CarDTO {
		[XmlElement]
		public int Id { get; set; }
		[XmlElement]
		public string Name { get; set; }
		[XmlElement]
		public int Year { get; set; }
		[XmlElement]
		public int Power { get; set; }
		[XmlElement]
		public int TransmittionType { get; set; }
		[XmlElement]
		public int FuelType { get; set; }
		[XmlElement]
		public int BodyType { get; set; }
		[XmlElement]
		public int Speed { get; set; }
		[XmlElement]
		public decimal Price { get; set; }
		[XmlElement]
		public string LicenseNumber { get; set; }
	}
}
