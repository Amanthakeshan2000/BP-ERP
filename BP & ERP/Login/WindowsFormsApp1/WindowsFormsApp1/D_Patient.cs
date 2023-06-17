using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class D_Patient : UserControl
    {
        public D_Patient()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Today Patients
            d_Patient_11.Show();
            d_Patient_11.BringToFront();


            d_Patient_21.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //All Patients
            d_Patient_21.Show();
            d_Patient_21.BringToFront();


            d_Patient_11.Hide();
        }
    }
}
