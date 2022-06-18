using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CarRental.EF;
using CarRental.BL;
using System.Collections;

namespace CarRental {
	public class CarRentalService : ICarRentalService {
		public List<CarDTO> GetAllCars() => CarManagement.GetAllCars();
		public void AddNewCar(CarDTO car) => CarManagement.AddNewCar(car);
		public List<List<string>> GetComboboxValues() {
			List<List<string>> result = new List<List<string>>();
			using (CarRentalModel db = new CarRentalModel()) {
				result.Add(db.CarBodyTypes.Select(i => i.id.ToString()).ToList());
				result.Add(db.CarBodyTypes.Select(i => i.name.ToString()).ToList());
				result.Add(db.TransmissionTypes.Select(i => i.id.ToString()).ToList());
				result.Add(db.TransmissionTypes.Select(i => i.name.ToString()).ToList());
				result.Add(db.FuelTypes.Select(i => i.id.ToString()).ToList());
				result.Add(db.FuelTypes.Select(i => i.name.ToString()).ToList());
			}
			return result;
		}
	}
}
