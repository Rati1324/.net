using CarRental.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRental.BL {
	public class CarManagement {
		public static List<CarDTO> GetAllCars() {
			try {
				using (CarRentalModel db = new CarRentalModel()) {
				return db.Cars.Select(i => new CarDTO {
					Id = i.id,
					Name = i.name,
					Year = (int)i.year,
					BodyType = (int)i.body_type,
					FuelType = (int)i.fuel_type,
					TransmittionType = (int)i.transmission_type,
					Power = (int)i.power_hp,
					Speed = (int)i.speed,
					Price = (int)i.price,
					LicenseNumber = i.license_number,
				}).ToList();
			}
			} catch (Exception) {
				throw;
			}
			
		}
		public static void AddNewCar(CarDTO car) {
			try {
				using (CarRentalModel db = new CarRentalModel()) {
					Car c = new Car();
					c.name = car.Name;
					c.year = car.Year;
					c.price = car.Price;
					c.speed = car.Speed;
					c.power_hp = car.Power;
					c.body_type = car.BodyType;
					c.transmission_type = car.TransmittionType;
					c.fuel_type = car.FuelType;
					db.Cars.Add(c);
					db.SaveChanges();
				}
			} catch (Exception) {
				throw;
			}
		}

	}
}