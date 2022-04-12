using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermClient {
	public partial class Form1 : Form {
		string url = "http://localhost:57252/Services/Service1.svc";
		WebClient webClient = new WebClient();
		public Form1() {
			InitializeComponent();
		}

		private void importBtn_Click(object sender, EventArgs e) {
			try {
				string fullUrl = $"{url}/GetAllSmartphones";
				webClient.Encoding = Encoding.UTF8;
				var res = webClient.DownloadString(fullUrl);
				List<SmartphoneDTO> data = JsonConvert.DeserializeObject<List<SmartphoneDTO>>(res);
				phonesGrid.DataSource = data;
				phonesGrid.Columns["id"].Visible = false;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void addBtn_Click(object sender, EventArgs e) {
			AddPhoneForm f = new AddPhoneForm();
			f.Show();
		}

		private void deleteBtn_Click(object sender, EventArgs e) {
			try {
				string fullUrl = $"{url}/DeletePhone";
				string phoneId = phonesGrid.SelectedRows[0].Cells[0].Value.ToString();
				webClient.Headers["Content-type"] = "application/json";
				MemoryStream ms = new MemoryStream();
				DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(string));
				ser.WriteObject(ms, phoneId);

				webClient.Encoding = Encoding.UTF8;
				webClient.UploadData($"{fullUrl}/{phoneId}", "DELETE", ms.ToArray());

			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void editBtn_Click(object sender, EventArgs e) {
			DataGridViewCellCollection phoneData = phonesGrid.SelectedRows[0].Cells;
			AddPhoneForm f = new AddPhoneForm(phoneData);
			f.Show();
		}
	}
}
