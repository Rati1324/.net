using hw6.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace hw6.Controllers {
	public class StudentsController : ApiController {
		private Edu db = new Edu();

		// url dan ighebs studentis saxels da gvars da abrunebs studentis id-s (int)
		[System.Web.Http.HttpGet]
		[System.Web.Http.Route("student_id")]
		public int StudentId([FromUri]string firstName, [FromUri]string lastName) {
			var result = db.Students.Where(s => s.FirstName == firstName && s.LastName == lastName).Select(s => s.Id).First();
			return result;
		}

		[System.Web.Http.HttpGet]
		[System.Web.Http.Route("students", Name = "students")]
		public IHttpActionResult GetStudents() {
			var result = db.Students.Select(i => new StudentDTO {
				Id = i.Id,
				FirstName = i.FirstName,
				LastName = i.LastName,
				BirthDate = i.BirthDate,
				GPA = (float)i.GPA,
			}).ToList();
			return Json(result);
		}

		[System.Web.Http.Route("student/{id}", Name = "student")]
		[ResponseType(typeof(StudentDTO))]
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
			return Json(result);
		}

		[ResponseType(typeof(bool))]
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
				return Ok(true);
			} 
			catch (DbUpdateConcurrencyException) {
				if (S == null)
					return NotFound();
				else
					throw;
			}
		}

		[System.Web.Http.HttpPost]
		[System.Web.Http.Route("add_student")]
		[ResponseType(typeof(StudentDTO))]
		public async Task<IHttpActionResult> PostStudent(StudentDTO S) {
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			Student s = new Student {
				FirstName = S.FirstName,
				LastName = S.LastName,
				BirthDate = S.BirthDate,
				GPA = S.GPA
			};
			try {
				db.Students.Add(s);
				await db.SaveChangesAsync();
				return CreatedAtRoute("student", new { id = s.Id }, s);
			} catch (Exception) {
				throw;
			}
		}

		[ResponseType(typeof(bool))]
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