using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace FirstWcfService.DataContracts
{
	[DataContract]
    [Serializable]
    public class StudentDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public float GPA { get; set; }

        [DataMember]
        public DateTime BirthDate { get; set; }
    }
}