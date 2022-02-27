using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FirstWcfService
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FullName { get; set; }       
        
        [DataMember]
        public float GPA { get; set; }
    }
}