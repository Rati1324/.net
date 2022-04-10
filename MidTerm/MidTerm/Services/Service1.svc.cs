using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MidTerm.DataContracts;

namespace MidTerm {
	public class Service1 : IService1 {
		public List<SmartphoneDTO> GetAllPhones() {
			using (Model1 db = new Model1()) {
				return db.Smartphones.Select(s => new SmartphoneDTO {
					Id = s.id,
					Name = s.name,
					CpuSpeed = (float)s.CpuSpeed,
					Price = (decimal)s.price,
					SimCardTypeId = s.simCardTypeId,
					RAM = s.RAM,
					BrandId = s.Brand.name,
				}).ToList();
			}
		}

		public void AddNewPhone(SmartphoneDTO s) {
			try {
				using (Model1 db = new Model1()) {
					Smartphone sp = new Smartphone {
						name = s.Name,
						CpuSpeed = s.CpuSpeed,
						price = s.Price,
						brandId = s.BrandId,
						simCardTypeId = s.SimCardTypeId,
						RAM = s.RAM,
					};
					db.Smartphones.Add(sp);
					db.SaveChanges();
				}
			} catch (Exception) {
				throw;
			}
			
		}

		public void DeletePhone(string id) {
			try {
				using (Model1 db = new Model1()) {
					int intId;
					if (!int.TryParse(id, out intId)) {
						throw new Exception("Invalid input");
					}
					if (!db.Smartphones.Any(i => i.id == intId))
						throw new Exception ("No phone found");
					Smartphone s = db.Smartphones.Where(i => i.id == intId).First();
					db.Smartphones.Remove(s);
					db.SaveChanges();
				}
			} catch (Exception) {

				throw;
			}
		}

		public List<List<List<string>>> GetFields() {
			using (Model1 db = new Model1()) {
				List<List<List<string>>> fields = new List<List<List<string>>>();
				var simTypes = db.SimCardTypes.Select(i => new List<string>() { i.id.ToString(), i.name }).ToList();
				var brands = db.Brands.Select(i => new List<string>() { i.id.ToString(), i.name }).ToList();
				fields.Add(simTypes);
				fields.Add(brands);
				return fields;
			}
		}
	}
}
