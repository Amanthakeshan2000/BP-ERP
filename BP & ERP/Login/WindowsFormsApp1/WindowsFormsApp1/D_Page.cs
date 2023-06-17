using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class D_Page : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
int nLeftRect,     // x-coordinate of upper-left corner
int nTopRect,      // y-coordinate of upper-left corner
int nRightRect,    // x-coordinate of lower-right corner
int nBottomRect,   // y-coordinate of lower-right corner
int nWidthEllipse, // height of ellipse
int nHeightEllipse // width of ellipse
);
        public D_Page()
        {

            InitializeComponent();
            //label18.Text = uname;

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void D_Page_Load(object sender, EventArgs e)
        {
   

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {




            if (MessageBox.Show("Do You Want to Log Out", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dashboard
            d_Dashboard1.Show();
            d_Dashboard1.BringToFront();

            d_Doctor1.Hide();
            d_Patient1.Hide();
            d_Appoinment1.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Doctor
            d_Doctor1.Show();
            d_Doctor1.BringToFront();

            d_Dashboard1.Hide();
            d_Patient1.Hide();
            d_Appoinment1.Hide();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Patients
            d_Patient1.Show();
            d_Patient1.BringToFront();

            d_Dashboard1.Hide();
            d_Doctor1.Hide();
            d_Appoinment1.Hide();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Appoinments
            d_Appoinment1.Show();
            d_Appoinment1.BringToFront();

            d_Dashboard1.Hide();
            d_Doctor1.Hide();
            d_Patient1.Hide();
        }
    }
}
