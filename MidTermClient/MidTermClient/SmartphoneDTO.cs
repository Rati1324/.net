using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MidTermClient {
	[Serializable]
	public class SmartphoneDTO {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Brand { get; set; }
		public decimal Price { get; set; }
		public int RAM { get; set; }
		public float CpuSpeed { get; set; }
		public string SimCardType { get; set; }	
	}
}
