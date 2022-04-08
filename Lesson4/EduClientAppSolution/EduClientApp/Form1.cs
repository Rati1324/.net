using EduClientApp.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace EduClientApp
{
    public partial class Form1 : Form
    {
		string url = ConfigurationSettings.AppSettings["TestWCFService"];
		WebClient webClient = new WebClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void getAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
				webClient.Encoding = UTF8Encoding.UTF8;               
                string t = webClient.DownloadString($"{url}/GetAllStudents");
                List <StudentDTO> result = HelpMethods.JsonDeserialize<List<StudentDTO>>(t);
                studentGrid.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		private void addStudentToolStripMenuItem_Click(object sender, EventArgs e) {
			AddStudentForm F = new AddStudentForm();
			F.Show();
		}

		private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e) {
			var studentData = studentGrid.SelectedRows[0].Cells;
			MessageBox.Show(studentData.GetType().ToString());
			AddStudentForm F = new AddStudentForm(studentData);
			F.Show();
		}

		private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e) {
			try {
				int studentId = (int)studentGrid.SelectedRows[0].Cells[0].Value;

				ASCIIEncoding encoding = new ASCIIEncoding();

				HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"{url}/DeleteStudent/{studentId}");
				request.Method = "DELETE";
				Stream newStream = request.GetRequestStream();
				newStream.Close();

				WebResponse response = request.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader sr = new StreamReader(responseStream);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}
	}
}
