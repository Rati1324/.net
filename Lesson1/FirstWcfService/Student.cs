using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FirstWcfService {
	[DataContract]
    public class Student
    {
        //[DataMember]
        public int Id { get; set; }
        [DataMember]
		public string FirstName { get; set; }
        [DataMember]
		public string LastName { get; set; }
		[DataMember]
        public float GPA { get; set; }
		[DataMember]
		public DateTime dob { get; set; }
    }
}