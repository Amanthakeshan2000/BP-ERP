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
    public partial class D_Appoinment_1 : UserControl
    {
        public D_Appoinment_1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Today Waiting Appoinment
            d_Appoinment_1a1.Show();
            d_Appoinment_1a1.BringToFront();

            d_Appoinment_1b1.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Today All Appoinment
            d_Appoinment_1b1.Show();
            d_Appoinment_1b1.BringToFront();

            d_Appoinment_1a1.Hide();
        }
    }
}
