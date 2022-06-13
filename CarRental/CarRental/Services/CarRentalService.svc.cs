using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CarRental.EF;

namespace CarRental {
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarRentalService" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select CarRentalService.svc or CarRentalService.svc.cs at the Solution Explorer and start debugging.
	public class CarRentalService : ICarRentalService {
		public List<CarDTO> GetAllCars() {
			using (CarRentalModel db = new CarRentalModel()) {
				return db.Cars.Select(i => new CarDTO {
					Name = i.name
				}).ToList();
			}
		}
	}
}
