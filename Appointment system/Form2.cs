using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appointment_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wstGrp25DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.wstGrp25DataSet.Patient);

        }
        
        private void dgvPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                int rowIndex = e.RowIndex;
                int PatientID = Convert.ToInt32(dgvPatient.Rows[rowIndex].Cells[0].Value);
                 //int currentPatientID = selectedPatientID;
                txtPatientID.Text = PatientID.ToString();

                string name = dgvPatient.Rows[rowIndex].Cells[1].Value.ToString();
                txtName.Text = name;


                string surname = dgvPatient.Rows[rowIndex].Cells[2].Value.ToString();
                txtSurname.Text = surname;

                string email = dgvPatient.Rows[rowIndex].Cells[4].Value.ToString();
                txtEmail.Text = email;

                string phoneNumber = dgvPatient.Rows[rowIndex].Cells[6].Value.ToString();
                txtPhone.Text = phoneNumber;

                string streetName = dgvPatient.Rows[rowIndex].Cells[7].Value.ToString();
                txtStreetName.Text = streetName;

                string suburb = dgvPatient.Rows[rowIndex].Cells[10].Value.ToString();
                txtSuburb.Text = suburb;

                string city = dgvPatient.Rows[rowIndex].Cells[9].Value.ToString();
                txtCity.Text = city;

                int code = Convert.ToInt32(dgvPatient.Rows[rowIndex].Cells[8].Value);
                txtPostalCode.Text = code.ToString();
            }

        
        private void OKbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patient added!");
        }
    }
}
