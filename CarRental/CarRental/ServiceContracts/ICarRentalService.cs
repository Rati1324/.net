using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarRental {
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarRentalService" in both code and config file together.
	[ServiceContract]
	[XmlSerializerFormat]
	public interface ICarRentalService {
		[OperationContract]
		[WebGet(UriTemplate = "/GetAllCars", ResponseFormat = WebMessageFormat.Xml)]
        List<CarDTO> GetAllCars();
	}

}
