using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace CarRental {
	[DataContract]
    [Serializable]
    [XmlRoot]
	public class CarDTO {
		[DataMember]
		[XmlElement]
		public int Id { get; set; }
		[DataMember]
		[XmlElement]
		public string Name { get; set; }
		[DataMember]
		[XmlElement]
		public int Year { get; set; }
		[DataMember]
		[XmlElement]
		public int Power { get; set; }
		[DataMember]
		[XmlElement]
		public int TransmittionType { get; set; }
		[DataMember]
		[XmlElement]
		public int FuelType { get; set; }
		[DataMember]
		[XmlElement]
		public int BodyType { get; set; }
		[DataMember]
		[XmlElement]
		public int Speed { get; set; }
		[DataMember]
		[XmlElement]
		public decimal Price { get; set; }
		[DataMember]
		[XmlElement]
		public string LicenseNumber { get; set; }
	}
}