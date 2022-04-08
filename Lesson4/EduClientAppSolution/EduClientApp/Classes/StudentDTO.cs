using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EduClientApp.Classes
{
    [Serializable]
    public class StudentDTO
    {      
        public int Id { get; set; }      
     
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
     
        public float GPA { get; set; }
       
        public DateTime BirthDate { get; set; }
    }
}
