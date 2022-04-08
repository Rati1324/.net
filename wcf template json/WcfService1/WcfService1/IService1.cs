using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1 {
	[ServiceContract]
	public interface IService1 {
		[WebInvoke(UriTemplate = "/AddData", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, Method = "POST")]
		string AddData(Person p);
	}
}
