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
					SimCardType = s.SimCardType.name,
					RAM = s.RAM,
					Brand = s.Brand.name,
				}).ToList();
			}
		}

		public void AddNewPhone(SmartphoneDTO s) {
			try {
				using (Model1 db = new Model1()) {
					int brandId = db.Brands.Where(b => b.name == s.Brand).Select(i => i.id).First();
					int simCardTypeId = db.SimCardTypes.Where(sim => sim.name == s.SimCardType).Select(i => i.id).First();

					Smartphone sp = new Smartphone {
						name = s.Name,
						CpuSpeed = s.CpuSpeed,
						price = s.Price,
						brandId = brandId,
						simCardTypeId = simCardTypeId,
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

		public void EditPhone(SmartphoneDTO s) {
			try {
				using (Model1 db = new Model1()) {
					if (!db.Smartphones.Any(i => i.id == s.Id))
						throw new Exception("Phone not found");

					Smartphone sp = db.Smartphones.Where(i => i.id == s.Id).First();
					int simId = db.SimCardTypes.Where(i => i.name == s.SimCardType).Select(i => i.id).First();
					int brandId = db.Brands.Where(i => i.name == s.Brand).Select(i => i.id).First();

					sp.name = s.Name;
					sp.price = s.Price;
					sp.RAM = s.RAM;
					sp.simCardTypeId = simId;
					sp.CpuSpeed = s.CpuSpeed;
					sp.brandId = brandId;
					db.SaveChanges();
				}
			} catch (Exception) {

				throw;
			}
		}
		public List<List<string>> GetFields() {
			using (Model1 db = new Model1()) {
				List<List<string>> fields = new List<List<string>>();
				var simTypes = db.SimCardTypes.Select(i => i.name).ToList();
				var brands = db.Brands.Select(i => i.name ).ToList();
				fields.Add(simTypes);
				fields.Add(brands);
				return fields;
			}
		}
	}
}
