using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
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
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I50R950\SQLEXPRESS;Initial Catalog=Doctor_Register1;Integrated Security=True");


        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

  



        private void button1_Click(object sender, EventArgs e)
        {
            string uname=textBox1.Text;



            if (comboBox1.Text == "Doctor")
            {

                //Class1.uame = txtUname.Text;

                String username, user_password;
                username = textBox1.Text;
                user_password = textBox2.Text;

                try
                {
                    String query = "SELECT * FROM Doctor_Register_Table WHERE username='" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        username = textBox1.Text;
                        user_password = textBox2.Text;


                        Loading_Form3 d2 = new Loading_Form3(uname);
                        d2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Details", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        textBox2.Clear();

                        textBox1.Focus();


                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    conn.Close();
                }

            }
            //-----------------Admin------------------------------------>
            else if (comboBox1.Text == "Admin")
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {

                    Loading_Form3 d2 = new Loading_Form3(uname);
                    d2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Focus();


                }
            }



            //-----------------Receptionist------------------------------------>
            else if (comboBox1.Text == "Receptionist")
            {

                // MessageBox.Show("Not Created...");

                SqlConnection conn1 = new SqlConnection(@"Data Source=DESKTOP-I50R950\SQLEXPRESS;Initial Catalog=Reception_Login;Integrated Security=True");



                String username, user_password;
                username = textBox1.Text;
                user_password = textBox1.Text;


                try
                {
                    String query = "SELECT * FROM Reception_tb WHERE Username='" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn1);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        username = textBox1.Text;
                        user_password = textBox1.Text;

                        Loading_Form3 d2 = new Loading_Form3(uname);
                        d2.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Details", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        textBox2.Clear();

                        textBox1.Focus();


                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select Your Possition...");
            }





        }







        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (MessageBox.Show("Do You Want to Create Account", "Create Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                D_Form3 d1 = new D_Form3();
                d1.Show();
                this.Hide();

            }

        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text=DateTime.Now.ToLongTimeString();
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
