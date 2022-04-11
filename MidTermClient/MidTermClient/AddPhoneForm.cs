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
		int phoneId;
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
			updateBtn.Hide();
			string fullUrl = $"{url}/GetFields";
			webClient.Encoding = Encoding.UTF8;
			var res = webClient.DownloadString(fullUrl);
			var dres = JsonConvert.DeserializeObject<List<List<string>>>(res);
			var brands = dres[1];
			var simTypes = dres[0];

			foreach (var item in brands) {
				brandInput.Items.Add(item);
			}
			brandInput.SelectedIndex = 0;
			brandInput.DropDownStyle = ComboBoxStyle.DropDownList;

			foreach (var item in simTypes) {
				simTypeInput.Items.Add(item);
			}
			simTypeInput.SelectedIndex = 0;
			simTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		public AddPhoneForm(DataGridViewCellCollection phoneData): this() {
			addBtn.Hide();
			updateBtn.Show();

			for (int i = 0; i < brandInput.Items.Count; i++) {
				if (brandInput.Items[i].ToString() == phoneData[2].Value.ToString()) {
					brandInput.SelectedIndex = i;
				}
			}
			for (int i = 0; i < simTypeInput.Items.Count; i++) {
				if (simTypeInput.Items[i].ToString() == phoneData[6].Value.ToString()) {
					simTypeInput.SelectedIndex = i;
				}
			}
			nameInput.Text = phoneData[1].Value.ToString();
			priceInput.Text = phoneData[3].Value.ToString();
			ramInput.Text = phoneData[4].Value.ToString();
			cpuInput.Text = phoneData[5].Value.ToString();

			this.phoneId = (int)phoneData[0].Value;
		}

		private void addBtn_Click(object sender, EventArgs e) {
			string fullUrl = $"{url}/AddNewSmartPhone";
			SmartphoneDTO s = new SmartphoneDTO {
				Name = nameInput.Text,
				Brand = brandInput.Items[brandInput.SelectedIndex].ToString(),
				Price = decimal.Parse(priceInput.Text),
				RAM = Int32.Parse(ramInput.Text),
				CpuSpeed = float.Parse(cpuInput.Text),
				SimCardType = simTypeInput.SelectedItem.ToString(),
			};
			var js = JsonConvert.SerializeObject(s);

			webClient.Headers["Content-type"] = "application/json";
			webClient.Encoding = Encoding.UTF8;
			webClient.UploadString(fullUrl, "POST", js);
		}

		private void updateBtn_Click(object sender, EventArgs e) {
			string fullUrl = $"{url}/EditSmartphone";
			SmartphoneDTO s = new SmartphoneDTO {
				Id = this.phoneId,
				Name = nameInput.Text,
				Brand = brandInput.Items[brandInput.SelectedIndex].ToString(),
				Price = decimal.Parse(priceInput.Text),
				RAM = Int32.Parse(ramInput.Text),
				CpuSpeed = float.Parse(cpuInput.Text),
				SimCardType = simTypeInput.SelectedItem.ToString(),
			};
			var js = JsonConvert.SerializeObject(s);
			webClient.Headers["Content-type"] = "application/json";
			webClient.Encoding = Encoding.UTF8;
			webClient.UploadString(fullUrl, "POST", js);

		}
	}
}
