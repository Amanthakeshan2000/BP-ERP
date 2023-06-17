using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BPERP.Resources;

namespace BPERP
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();
         
        }

        SqlConnection conn=new SqlConnection(@"Data Source=DESKTOP-I50R950\SQLEXPRESS;Initial Catalog=Doctor_Register_1;Integrated Security=True");

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            if (form1Select.Text=="Doctor")
            {

                Class1.uame = txtUname.Text;

                String username, user_password;
                username = txtUname.Text;
                user_password = txtpsw.Text;


                try
                {
                    String query = "SELECT * FROM Doctor_Register_Table_1 WHERE Username='" + txtUname.Text + "' AND Password = '" + txtpsw.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        username = txtUname.Text;
                        user_password = txtpsw.Text;


                        Dashboard f = new Dashboard();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Details", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUname.Clear();
                        txtpsw.Clear();

                        txtUname.Focus();


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
            else if (form1Select.Text == "Admin")
            {
                MessageBox.Show("Not Created...");
            }
            else if (form1Select.Text == "Receptionist")
            {
                MessageBox.Show("Not Created...");
            }
            else
            {
                MessageBox.Show("Please Select Your Possition...");
            }
       
          
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

           
        }

   

        private void linkLabel1_LinkClicked_3(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Do You Want to Create Account", "Create Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                doctor_Register_new1.Show();
                doctor_Register_new1.BringToFront();
            }



        }

        private void linkreset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUname.Text = Convert.ToString("");
            txtpsw.Text = Convert.ToString("");
        }

        private void doctor_Register_new1_Load(object sender, EventArgs e)
        {

        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            Dashboard d1 = new Dashboard();
             
        }
    }
}
