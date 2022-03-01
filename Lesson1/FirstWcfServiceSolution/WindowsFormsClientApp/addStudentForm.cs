using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClientApp {
	public partial class addStudentForm : Form {
		public addStudentForm() 
		{
			InitializeComponent();
		}

		private void addBtn_Click(object sender, EventArgs e) 
		{
			ServiceEdu.EduServiceClient client = new ServiceEdu.EduServiceClient();
			ServiceEdu.Student O = new ServiceEdu.Student 
			{
				FullName = fNameInput.Text + " " + lNameInput.Text,
				GPA = float.Parse(gpaInput.Text),
				DateOfBirth = dobInput.Value,
			};
			client.AddNewStudent(O);
		}
	}
}
