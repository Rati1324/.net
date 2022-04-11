using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MidTerm.DataContracts {
	[DataContract]
	[Serializable]
	public class SmartphoneDTO {
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public string Brand { get; set; }
		[DataMember]
		public decimal Price { get; set; }
		[DataMember]
		public int RAM { get; set; }
		[DataMember]
		public float CpuSpeed { get; set; }
		[DataMember]
		public string SimCardType { get; set; }
	}
}