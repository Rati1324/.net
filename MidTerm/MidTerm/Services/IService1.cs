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
	[ServiceContract]
	public interface IService1 {
		[OperationContract]
        [WebGet(UriTemplate = "/GetAllSmartPhones", ResponseFormat = WebMessageFormat.Json)]
		List<SmartphoneDTO> GetAllPhones();

		[OperationContract]
		[WebInvoke(UriTemplate = "/AddNewSmartphone", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST", BodyStyle = WebMessageBodyStyle.Bare)]
		void AddNewPhone(SmartphoneDTO s);

		[OperationContract]
		[WebGet(UriTemplate = "/GetFields", ResponseFormat = WebMessageFormat.Json)]
		List<List<List<string>>> GetFields();

		[OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/DeletePhone/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
		void DeletePhone(string id);
	}
}
