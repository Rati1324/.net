using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EduClientApp.Classes
{
    [Serializable]
    //[XmlRoot(Namespace = "ArrayOfStudentDTO")]
    public class StudentDTO
    {      
        [XmlElement]
        public int Id { get; set; }      
     
        [XmlElement]
        public string FirstName { get; set; }
      
        [XmlElement]
        public string LastName { get; set; }
     
        [XmlElement]
        public float GPA { get; set; }
       
        [XmlElement]
        public DateTime BirthDate { get; set; }
    }
}
