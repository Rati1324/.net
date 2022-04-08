using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduClientApp.Classes;
using System.Net;
using System.IO;
using System.Xml;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;

namespace EduClientApp {
	public partial class AddStudentForm : Form {
		int studentId;
		public AddStudentForm() {
			InitializeComponent();
			updateBtn.Hide();
		}
		public AddStudentForm(DataGridViewCellCollection data) {
			InitializeComponent();
			this.studentId = (int)data[0].Value;
			addBtn.Hide();
			fNameInput.Text = data[1].Value.ToString();
			lNameInput.Text = data[2].Value.ToString();
			gpaInput.Text = data[3].Value.ToString();
			dobInput.Value = (DateTime)data[4].Value;
		}

		string url = ConfigurationSettings.AppSettings["TestWCFService"];

		private void addBtn_Click(object sender, EventArgs e) {

			StudentDTO S = new StudentDTO {
				FirstName = fNameInput.Text,
				LastName = lNameInput.Text,
				GPA = float.Parse(gpaInput.Text),
				BirthDate = dobInput.Value,
			};

			try {
				//var cli = new WebClient();
				//string response = cli.UploadString($"{url}/AddNewStudent", HelpMethods.JsonSerialize(S));

					//string data = HelpMethods.JsonSerialize(S);

					DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(StudentDTO));    
					MemoryStream mem = new MemoryStream();
					ser.WriteObject(mem, S);
					string data = Encoding.UTF8.GetString(mem.ToArray(), 0, (int)mem.Length);
					MessageBox.Show(data);

					WebClient webClient = new WebClient();
					webClient.Headers["Content-type"] = "application/json";
					webClient.Encoding = Encoding.UTF8;
					string fullUrl = $"{url}/AddNewStudent";
					var response = webClient.UploadString(fullUrl, "POST", data);
					MessageBox.Show(response);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void updateBtn_Click(object sender, EventArgs e) {
			StudentDTO S = new StudentDTO {
				Id = this.studentId,
				FirstName = fNameInput.Text,
				LastName = lNameInput.Text,
				GPA = float.Parse(gpaInput.Text),
				BirthDate = dobInput.Value,
			};

			try {
				string postData = HelpMethods.Serialize<StudentDTO>(S).OuterXml;

				ASCIIEncoding encoding = new ASCIIEncoding();
				byte[] data = encoding.GetBytes(postData);

				HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{url}/UpdateStudent");
				request.Method = "PUT";
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
