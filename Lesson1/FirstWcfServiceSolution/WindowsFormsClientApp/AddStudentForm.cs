using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClientApp {
	public partial class AddStudentForm : Form {
		public AddStudentForm() {
			InitializeComponent();
		}

		private void addBtn_Click(object sender, EventArgs e) {
			ServiceReference1.EduServiceClient client = new ServiceReference1.EduServiceClient();
			ServiceReference1.Student S = new ServiceReference1.Student { 
				FirstName=fNameInput.Text, 
				LastName=lNameInput.Text,
				GPA=float.Parse(gpaInput.Text),
				dob=dobInput.Value
			};
			client.AddNewStudent(S);
		}
	}
}
