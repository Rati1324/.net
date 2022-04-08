using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace WcfClient {
	class Program {
		static void Main(string[] args) {
			Person p = new Person { FirstName = "john", LastName = "Johnson" };
			string url = "http://localhost:59308/Service1.svc/AddData";

			var jp = JsonConvert.SerializeObject(p);
			WebClient webClient = new WebClient();
			webClient.Headers["Content-type"] = "application/json";
			webClient.Encoding = Encoding.UTF8;
			
			string res = webClient.UploadString(url, "POST", jp);
			Console.WriteLine(res);
		}
	}
}
