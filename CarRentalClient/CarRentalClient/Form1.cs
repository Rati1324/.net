using CarRentalClient.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalClient {
	public partial class Form1 : Form {
		string url = ConfigurationSettings.AppSettings["CarRentalService"];
		WebClient webClient = new WebClient();

		public Form1() {
			InitializeComponent();
		}

		private void importBtn_Click(object sender, EventArgs e) {
			webClient.Encoding = UTF8Encoding.UTF8;
			string t = webClient.DownloadString($"{url}/GetAllCars");
			string st = t.Replace("xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"", "");
			MessageBox.Show(st);
			List<CarDTO> result = HelpMethods.Deserialize<List<CarDTO>>(st, "ArrayOfCarDTO");
			carsGrid.DataSource = result;
		}

		private void insertBtn_Click(object sender, EventArgs e) {
			Form f = new InputForm();
			f.Show();
		}
	}
}
