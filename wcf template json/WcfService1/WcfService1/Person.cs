using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1 {
	[DataContract]
	[Serializable]
	public class Person {
		[DataMember]
		public string FirstName { get; set; }
		[DataMember]
		public string LastName { get; set; }
	}
}