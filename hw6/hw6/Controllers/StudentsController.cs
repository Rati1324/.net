using hw6.EF;
using hw6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace hw6.Controllers {
	public class StudentsController : ApiController {
		private EduDb db = new EduDb();

		// GET: Students
		public IHttpActionResult GetStudents() {
			var result = db.Students.Select(i => new StudentDTO {
				Id = i.Id,
				FirstName = i.FirstName,
				LastName = i.LastName,
				BirthDate = i.BirthDate,
				GPA = (float)i.GPA,
			});
			return Json(result);
		}

		// GET: Student
		public IHttpActionResult GetStudent(int id) {
			var student = db.Students.FirstOrDefault(i => i.Id == id);
			if (student == null) {
				return NotFound();
			}
			var result = new StudentDTO {
				Id = student.Id,
				FirstName = student.FirstName,
				LastName = student.LastName,
				BirthDate = student.BirthDate,
				GPA = (float)student.GPA
			};
			return Ok(result);
		}

		public IHttpActionResult PutStudent(StudentDTO S) {
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			try {
				Student s = db.Students.FirstOrDefault(i => i.Id == S.Id);
				s.Id = S.Id;
				s.FirstName = S.FirstName;
				s.LastName = S.LastName;
				s.BirthDate = S.BirthDate;
				s.GPA = S.GPA;
				db.SaveChanges();
			} 
			catch (DbUpdateConcurrencyException) {
				if (S == null)
					return NotFound();
				else
					throw;
			}
			return Ok(true);
		}
		public IHttpActionResult PostStudent(StudentDTO S) {
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			Student s = new Student {
				FirstName = S.FirstName,
				LastName = S.LastName,
				BirthDate = S.BirthDate,
				GPA = S.GPA
			};
			db.Students.Add(s);
			db.SaveChanges();
			return Ok(true);
		}

		public IHttpActionResult DeleteStudent(int Id) {
			Student s = db.Students.FirstOrDefault(i => i.Id == Id);
			if (s == null)
				return NotFound();
			db.Students.Remove(s);
			db.SaveChanges();
			return Ok(true);
		}
	}
}