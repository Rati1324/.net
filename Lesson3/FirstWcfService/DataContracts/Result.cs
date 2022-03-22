using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Serialization;

namespace FirstWcfService.DataContracts
{
    [DataContract(Namespace ="Test")]
    [Serializable]
    [XmlRoot(Namespace = "Test")]
    public class Result
    {
        [DataMember]
        [XmlElement]
        public bool IsSuccess { get; set; }
        [DataMember]
        [XmlElement]
        public string ErrorMessage { get; set; }
    }
}