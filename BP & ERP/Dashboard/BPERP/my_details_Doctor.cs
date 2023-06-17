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


namespace BPERP
{
    public partial class my_details_Doctor : UserControl
    {


        string connectionString = @"Data Source=DESKTOP-I50R950\SQLEXPRESS;Initial Catalog=Doctor_Register_1;Integrated Security=True;";
        public my_details_Doctor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_My_Details1.Hide();

            //dataGridView1.Show();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Doctor_Register_Table_1",sqlCon);
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                dataGridView1.AutoGenerateColumns=false;
                dataGridView1.DataSource = dtb1;
            }

        }

        private void my_details_Doctor_Load(object sender, EventArgs e)
        {
            //dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit_My_Details1.Show();

        }


    }
}
