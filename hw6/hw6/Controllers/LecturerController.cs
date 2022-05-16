using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using hw6.Models;
using Microsoft.AspNetCore.Mvc;

namespace hw6.Controllers
{
	public class LecturerController : ApiController {
		private Edu db = new Edu();

		[System.Web.Http.HttpGet]
		[System.Web.Http.Route("lecturers")]
		public IHttpActionResult GetLecturers() {
			try {
				var result = db.Lecturers.Select(i => new LecturerDTO {
					FirstName = i.FirstName,
					LastName = i.LastName,
					Phone = i.Phone,
				}).ToList();
				return Json(result);
			} catch (Exception) {
				throw;
			}
		}

		[System.Web.Http.HttpGet]
		[System.Web.Http.Route("lecturer", Name = "lecturer")]
		public IHttpActionResult GetLecturer([FromUri]string firstName, [FromUri]string lastName) {
			try {
				var result = db.Lecturers.Where(l => l.FirstName == firstName && l.LastName == lastName).Select(i => new LecturerDTO {
					FirstName = i.FirstName,
					LastName = i.LastName,
					Phone = i.Phone,
				}).ToList();
				if (result.Count == 0) {
					return NotFound();
				}
				return Json(result);
			} catch (Exception) {
				throw;
			}
		}

		// amatebs leqtors da abrunebs im leqtoris obieqts jsonshi da headerebshi urls
		// abrunebs damatebuli leqtoris gverdistvis
		[System.Web.Http.HttpGet]
		[System.Web.Http.Route("add_lecturer")]
		public async Task<IHttpActionResult> AddLecturer(LecturerDTO L) {
			try {
				Lecturer l = new Lecturer {
					FirstName = L.FirstName,
					LastName = L.LastName,
					Phone = L.Phone,
				};
				db.Lecturers.Add(l);
				await db.SaveChangesAsync();
				return CreatedAtRoute("lecturer", new { firstName = l.FirstName, lastName = l.LastName }, l);
				//return RedirectToRoute("lecturer", new { firstName = l.FirstName, lastName = l.LastName });
			} catch (Exception) {
				throw;
			}
		}

		// aeditebs leqtors da redirects aketebs 
		[System.Web.Http.HttpPut]
		[System.Web.Http.Route("edit_lecturer")]
		public IHttpActionResult EditLecturer(LecturerDTO L) {
			if (!ModelState.IsValid)
				return BadRequest(ModelState);
			try {
				var l = db.Lecturers.FirstOrDefault(i => i.id == L.Id);
				if (l == null) {
					return NotFound();
				}
				l.FirstName = L.FirstName;
				l.LastName = L.LastName;
				l.Phone = L.Phone;
				db.SaveChanges();
				return RedirectToRoute("lecturer", new { firstName = l.FirstName, lastName = l.LastName });
			} catch (Exception) {
				throw;
			}
		}

		// shlis leqtors da abrunebs 204 status kods
		[System.Web.Http.HttpDelete]
		[System.Web.Http.Route("delete_lecturer")]
		public IHttpActionResult DeleteLecturer(int id) {
			try {
				var L = db.Lecturers.FirstOrDefault(i => i.id == id);
				if (L == null)
					return NotFound();
				db.Lecturers.Remove(L);
				db.SaveChanges();
				return StatusCode(HttpStatusCode.NoContent);
			} catch (Exception) {
				throw;
			}
		}
    }
}