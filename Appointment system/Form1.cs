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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                staffTableAdapter1.FillBy(wstGrp25DataSet1.Staff, txtUsername.Text, txtPassword.Text);
                if (wstGrp25DataSet1.Staff.Rows.Count > 0)
                {


                }

                Form2 f2 = new Form2();
                f2.Show();
               

            }
            catch (Exception)
            {
                MessageBox.Show("User not logged in");

            }
 
           
        }
    }
}
