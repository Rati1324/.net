using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermClient {
	public partial class AddPhoneForm : Form {
		WebClient webClient = new WebClient();
		string url = "http://localhost:57252/Services/Service1.svc";

		public class ComboboxItem {
			public string Text { get; set; }
			public int Value { get; set; }
			public override string ToString()
			{
				return Text;
			}
		}

		public AddPhoneForm() {
			InitializeComponent();
			string fullUrl = $"{url}/GetFields";
			webClient.Encoding = Encoding.UTF8;
			var res = webClient.DownloadString(fullUrl);
			var dres = JsonConvert.DeserializeObject<List<List<List<string>>>>(res);
			var brands = dres[1];
			var simTypes = dres[0];

			foreach (var item in brands) {
				ComboboxItem ci = new ComboboxItem { Value = Int32.Parse(item[0]), Text = item[1] };
				brandInput.Items.Add(ci);
			}
			brandInput.SelectedIndex = 0;
			brandInput.DropDownStyle = ComboBoxStyle.DropDownList;

			foreach (var item in simTypes) {
				ComboboxItem ci = new ComboboxItem { Value = Int32.Parse(item[0]), Text = item[1] };
				simTypeInput.Items.Add(ci);
			}
			simTypeInput.SelectedIndex = 0;
			simTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		public AddPhoneForm(DataGridViewCellCollection phoneData) {
			//nameInput.Text = phoneData[0].Value.ToString();
			//brandInput. = phoneData[1].Value.ToString();
			//phoneData[1].Value.ToString()
			//phoneData[1].Value.ToString()
			//phoneData[1].Value.ToString()
			//phoneData[1].Value.ToString()

		}
		private void addBtn_Click(object sender, EventArgs e) {
			MessageBox.Show((brandInput.SelectedItem as ComboboxItem).Value.ToString());
			MessageBox.Show((simTypeInput.SelectedItem as ComboboxItem).Value.ToString());
			string fullUrl = $"{url}/AddNewSmartPhone";
			SmartphoneDTO s = new SmartphoneDTO {
				Name = nameInput.Text,
				BrandId = 1,
				Price = decimal.Parse(priceInput.Text),
				RAM = Int32.Parse(ramInput.Text),
				CpuSpeed = float.Parse(cpuInput.Text),
				SimCardTypeId = (simTypeInput.SelectedItem as ComboboxItem).Value,
			};
			var js = JsonConvert.SerializeObject(s);

			webClient.Headers["Content-type"] = "application/json";
			webClient.Encoding = Encoding.UTF8;
			webClient.UploadString(fullUrl, "POST", js);
		}
	}
}
