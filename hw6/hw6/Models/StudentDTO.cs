using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw6.Models {
	public class StudentDTO {
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public float GPA { get; set; }
	}
}