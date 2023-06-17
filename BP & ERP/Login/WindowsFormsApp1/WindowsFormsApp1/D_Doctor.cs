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
    public partial class D_Doctor : UserControl
    {
        public D_Doctor()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            //doctor list
            d_Doctor_11.Show();
            d_Doctor_11.BringToFront();
           

            d_Doctor_21.Hide();
            d_Doctor_31.Hide();





        }    

        private void button1_Click_1(object sender, EventArgs e)
        {


            //my details
            d_Doctor_21.Show();
            d_Doctor_21.BringToFront();

            d_Doctor_11.Hide();
            d_Doctor_31.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Edit my details
            d_Doctor_31.Show();
            d_Doctor_31.BringToFront();

            d_Doctor_11.Hide();
            d_Doctor_21.Hide();
        }
    }
}
