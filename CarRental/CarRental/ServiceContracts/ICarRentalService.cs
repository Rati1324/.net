using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CarRental {
	[ServiceContract]
	[XmlSerializerFormat]
	public interface ICarRentalService {
		[OperationContract]
		[WebGet(UriTemplate = "/GetAllCars", ResponseFormat = WebMessageFormat.Xml)]
        List<CarDTO> GetAllCars();

		[OperationContract]
		[WebGet(UriTemplate = "/GetComboBoxValues", ResponseFormat = WebMessageFormat.Xml)]
        List<List<string>> GetComboboxValues();

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "/AddNewCar", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Bare)]
		void AddNewCar(CarDTO car);

	}
}
