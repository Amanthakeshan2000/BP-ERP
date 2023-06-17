﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class D_Doctor_1 : UserControl
    {
        string connectionString = @"Data Source=DESKTOP-I50R950\SQLEXPRESS;Initial Catalog=Doctor_Register1;Integrated Security=True";
        public D_Doctor_1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void D_Doctor_1_Load(object sender, EventArgs e)
        {
            //data

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Doctor_Register_Table", conn);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
            }

        }
    }
}
