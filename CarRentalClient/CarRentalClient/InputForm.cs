using CarRentalClient.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalClient {
	public partial class InputForm : Form {
		string url = ConfigurationSettings.AppSettings["CarRentalService"];
		WebClient webClient = new WebClient();

		public class Item {
			public int Id { get; set; }
			public string Name { get; set; }
		}

		public InputForm() {
			InitializeComponent();

			webClient.Encoding = UTF8Encoding.UTF8;
			string t = webClient.DownloadString($"{url}/GetComboBoxValues");
			string st = t.Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "");
			List<List<string>> result = HelpMethods.Deserialize<List<List<string>>>(st, "ArrayOfArrayOfString");

			var bodyTypes = new List<Item>();
			for (int i = 0; i < result[0].Count; i++) {
				bodyTypes.Add(new Item() { Id = Int32.Parse(result[0][i]), Name = result[1][i] });
			}
			typeInput.ValueMember = "Id";
			typeInput.DisplayMember = "Name";
			typeInput.DataSource = bodyTypes;
			typeInput.SelectedIndex = 0;
			
			var transmissionTypes = new List<Item>();
			for (int i = 0; i < result[2].Count; i++) {
				transmissionTypes.Add(new Item() {
					Id = Int32.Parse(result[2][i]),
					Name = result[3][i]
				});
			}
			transmissionInput.ValueMember = "Id";
			transmissionInput.DisplayMember= "Name";
			transmissionInput.DataSource = transmissionTypes;
			transmissionInput.SelectedIndex = 0;

			var fuelTypes = new List<Item>();
			for (int i = 0; i < result[4].Count; i++) {
				fuelTypes.Add(new Item() {
					Id = Int32.Parse(result[4][i]),
					Name = result[5][i]
				});
			}
			fuelInput.ValueMember = "Id";
			fuelInput.DisplayMember = "Name";
			fuelInput.DataSource = fuelTypes;
			fuelInput.SelectedIndex = 0;

		}

		private void insertBtn_Click(object sender, EventArgs e) {
			CarDTO c = new CarDTO {
				Name = nameInput.Text,
				Year = Int32.Parse(yearInput.Text),
				Power = Int32.Parse(powerInput.Text),
				TransmittionType = Int32.Parse(powerInput.Text),
				FuelType = Int32.Parse(fuelInput.Text),
				BodyType = Int32.Parse(typeInput.Text),
				Speed = Int32.Parse(speedInput.Text),
				LicenseNumber = licenseIntput.Text,
			};
			try {
				string car = HelpMethods.Serialize<CarDTO>(c).OuterXml;
				ASCIIEncoding encoding = new ASCIIEncoding();
				byte[] data = encoding.GetBytes(car);

				HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{url}/AddNewCar");
				request.Method = "POST";
				request.ContentType = "application/xml";
				request.ContentLength = data.Length;
				Stream newStream = request.GetRequestStream();
				newStream.Write(data, 0, data.Length);
				newStream.Close();

				WebResponse response = request.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader sr = new StreamReader(responseStream);
				string s = sr.ReadToEnd();
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
	}
}
