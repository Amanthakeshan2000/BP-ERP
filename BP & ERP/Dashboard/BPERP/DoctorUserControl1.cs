﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BPERP
{
    public partial class DoctorUserControl1 : UserControl
    {


        //SqlCommand cmd;
       // SqlConnection conn;
       // SqlDataAdapter da;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-I50R950\\SQLEXPRESS;Initial Catalog=Doctor_Register_1;Integrated Security=True");


        public DoctorUserControl1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // _2_DoctorListUserControl11.Show();
           // _2_DoctorListUserControl11.BringToFront();
        }

        private void DoctorUserControl1_Load(object sender, EventArgs e)
        {
           // _2_DoctorListUserControl11.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // _2_DoctorListUserControl11.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {


   




           
                string insertQuary = "INSERT INTO Doctor_Register_Table_1(Doctor_Id, Username, Password, Re_Enter, Doctor_Name, Email, Designation, Degrees, Department, Specialist, Doctor_Experience, BirthDay, Phone_Number) VALUES('" + textBox13.Text + "', '" + textBox12.Text + "', '" + textBox2.Text + "', '" + textBox11.Text + "', '" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "')";
                conn.Open();
                SqlCommand cmd = new SqlCommand(insertQuary, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                if (MessageBox.Show("Are You Sure Create New Account", "Create Doctor Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Data Insert Successful...!");
                }
            }
            else
                {
                    MessageBox.Show("Data Not Insert...!");
                }
                conn.Close();
            



            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-I50R950\\SQLEXPRESS;Initial Catalog=Doctor_Register_1;Integrated Security=True");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("INSERT INTO Doctor_Register_Table_1 VALUES(@Doctor_Id,@Username,@Password,@Re_Enter,@Doctor_Name,@Email,@Designation,@Degrees,@Department,@Specialist,@Doctor_Experience,@BirthDay,@Phone_Number)", conn);

            //  cmd.Parameters.AddWithValue("@Doctor_Id",int.Parse(textBox13.Text));
            // cmd.Parameters.AddWithValue("@Username", textBox12.Text);
            //  cmd.Parameters.AddWithValue("@Password", textBox2.Text);
            //  cmd.Parameters.AddWithValue("@Re_Enter", textBox11.Text);
            //  cmd.Parameters.AddWithValue("@Doctor_Name", textBox1.Text);
            //  cmd.Parameters.AddWithValue("@Email", textBox3.Text);
            //  cmd.Parameters.AddWithValue("@Designation", textBox4.Text);
            //  cmd.Parameters.AddWithValue("@Degrees", textBox5.Text);
            //  cmd.Parameters.AddWithValue("@Specialist", textBox7.Text);
            //  cmd.Parameters.AddWithValue("@Doctor_Experience", textBox8.Text);
            //  cmd.Parameters.AddWithValue("@BirthDay", textBox9.Text);
            //  cmd.Parameters.AddWithValue("@Phone_Number", textBox10.Text);

            //  conn.Close();
            //   MessageBox.Show("Successfully Saved...!");

            //conn=new SqlConnection(@"Data Source=DESKTOP-I50R950\SQLEXPRESS;Initial Catalog=Doctor_Register_1;Integrated Security=True");

            // conn.Open();
            cmd = new SqlCommand("INSERT INTO Doctor_Register_Table_1(Doctor_Id,Username,Password,Re_Enter,Doctor_Name,Email,Designation,Degrees,Department,Specialist,Doctor_Experience,BirthDay,Phone_Number) VALUES ('"+ textBox13.Text + "','"+ textBox12.Text + "','"+ textBox2.Text + "','"+ textBox11.Text + "','"+ textBox1.Text + "','"+ textBox3.Text + "','"+ textBox4.Text + "','"+ textBox5.Text + "','"+ textBox6.Text + "','"+ textBox7.Text + "','"+ textBox8.Text + "','"+ textBox9.Text + "','"+ textBox10.Text + "')", conn);
            //   cmd.Parameters.Add("@Doctor_Id", textBox12.Text);
            //   cmd.Parameters.Add("@Username",textBox12.Text);
            //    cmd.Parameters.Add("@Password", textBox2.Text);
            //    cmd.Parameters.Add("@Re_Enter", textBox11.Text);
            //    cmd.Parameters.Add("@Doctor_Name",textBox1.Text);
            //    cmd.Parameters.Add("@Email",textBox3.Text);
            //    cmd.Parameters.Add("@Designation", textBox4.Text);
            //    cmd.Parameters.Add("@Degrees", textBox5.Text);
            //    cmd.Parameters.Add("@Department", textBox6.Text);
            //    cmd.Parameters.Add("@Specialist", textBox7.Text);
            //    cmd.Parameters.Add("@Doctor_Experience", textBox8.Text);
            //    cmd.Parameters.Add("@BirthDay", textBox9.Text);
            //   cmd.Parameters.Add("@Phone_Number", textBox10.Text);



            //cmd.ExecuteNonQuery();

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox13.Text = Convert.ToString("");
            textBox1.Text = Convert.ToString("");
            textBox12.Text = Convert.ToString("");
            textBox2.Text = Convert.ToString("");
            textBox11.Text = Convert.ToString("");
            textBox3.Text = Convert.ToString("");
            textBox4.Text = Convert.ToString("");
            textBox5.Text = Convert.ToString("");
            textBox6.Text = Convert.ToString("");
            textBox7.Text = Convert.ToString("");
            textBox8.Text = Convert.ToString("");
            textBox9.Text = Convert.ToString("");
            textBox10.Text = Convert.ToString("");

        }

        private void button5_Click(object sender, EventArgs e)
        {


            if(MessageBox.Show("Are You Sure Exit..." , "Exit Register Page" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }



                
            
        }
    }
}
