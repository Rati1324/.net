using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClientApp
{
    public partial class Form1 : Form
    {
        ServiceEdu.EduServiceClient client = new ServiceEdu.EduServiceClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void butRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtBoxID.Text))

                dataGridView1.DataSource = client.GetAllStudents().ToList();
                else
                {
                    int id = Convert.ToInt32(txtBoxID.Text);

                    ServiceEdu.Student o = client.GetStudentById(id);

                    dataGridView1.DataSource = new List<ServiceEdu.Student> { o };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
