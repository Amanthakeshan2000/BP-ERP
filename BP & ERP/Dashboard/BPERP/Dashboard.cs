using BPERP.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPERP
{
    public partial class Dashboard : Form
    {

       
       
        public Dashboard()
        {
            InitializeComponent();
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            edit_My_Details1.Hide();

            //Dashboard

            userControl1Dashboard1.Show();
            userControl1Dashboard1.BringToFront();

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            my_details_Doctor1.Hide();


            


        // int w=Screen.PrimaryScreen.Bounds.Width;
        //int h=Screen.PrimaryScreen.Bounds.Height;

            // this.Location = new Point(0, 0);
            //this.Size = new Size(w, h);




            //doctorUserControl11.Hide();
            //  userControl2patient1.Hide();

            //   appoinmentUserControl11.Hide();
            //   prescriptionUserControl11.Hide();
            //   paymentUserControl11.Hide();
            //   invoiceUserControl11.Hide();
            //  scheduleUserControl11.Hide();
            //  emergency_StopUserControl11.Hide();
            //   setup_DataUserControl11.Hide();
            //   users_UserControl11.Hide();
            //  web_SettingUserControl11.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            //   userControl2patient1.Hide();
            //  userControl1Dashboard1.Hide();
            //   appoinmentUserControl11.Hide();
            //   prescriptionUserControl11.Hide();
            //   paymentUserControl11.Hide();
            //   invoiceUserControl11.Hide();
            //   scheduleUserControl11.Hide();
            //   emergency_StopUserControl11.Hide();
            //   setup_DataUserControl11.Hide();
            //   users_UserControl11.Hide();
            //   web_SettingUserControl11.Hide();

            //  doctorUserControl11.Show();
            //  doctorUserControl11.BringToFront();

            my_details_Doctor1.Show();
            my_details_Doctor1.BringToFront();





        }

        private void button4_Click(object sender, EventArgs e)
        {
         //   doctorUserControl11.Hide();
         //   userControl1Dashboard1.Hide();
         //   appoinmentUserControl11.Hide();
         //   prescriptionUserControl11.Hide();
         //   paymentUserControl11.Hide();
         //   invoiceUserControl11.Hide();
         //   scheduleUserControl11.Hide();
         //   emergency_StopUserControl11.Hide();
         //   setup_DataUserControl11.Hide();
         //   users_UserControl11.Hide();
         //   web_SettingUserControl11.Hide();

         //   userControl2patient1.Show();
         //   userControl2patient1.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
         //   doctorUserControl11.Hide();
         //   userControl1Dashboard1.Hide();
          //  userControl2patient1.Hide();
         //   prescriptionUserControl11.Hide();
          //  paymentUserControl11.Hide();
         //   invoiceUserControl11.Hide();
         //   scheduleUserControl11.Hide();
         //   emergency_StopUserControl11.Hide();
          //  setup_DataUserControl11.Hide();
         //   users_UserControl11.Hide();
         //   web_SettingUserControl11.Hide();

          //  appoinmentUserControl11.Show();
          //  appoinmentUserControl11.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Prescription

          //  doctorUserControl11.Hide();
         //   userControl1Dashboard1.Hide();
          //  userControl2patient1.Hide();
          //  appoinmentUserControl11.Hide();
         //   paymentUserControl11.Hide();
         //   invoiceUserControl11.Hide();
         //   scheduleUserControl11.Hide();
         //   emergency_StopUserControl11.Hide();
          //  setup_DataUserControl11.Hide();
          //  users_UserControl11.Hide();
         //   web_SettingUserControl11.Hide();


          //  prescriptionUserControl11.Show();
         //   prescriptionUserControl11.BringToFront();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Payment
          //  doctorUserControl11.Hide();
          //  userControl1Dashboard1.Hide();
          //  userControl2patient1.Hide();
         //   appoinmentUserControl11.Hide();
          //  prescriptionUserControl11.Hide();

            
          //  invoiceUserControl11.Hide();
          //  scheduleUserControl11.Hide();
          //  emergency_StopUserControl11.Hide();
         //   setup_DataUserControl11.Hide();
          //  users_UserControl11.Hide();
          //  web_SettingUserControl11.Hide();


         //   paymentUserControl11.Show();
          //  paymentUserControl11.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Invoice
          //  doctorUserControl11.Hide();
          //  userControl1Dashboard1.Hide();
         //   userControl2patient1.Hide();
          //  appoinmentUserControl11.Hide();
         //   prescriptionUserControl11.Hide();

          //  paymentUserControl11.Hide();
           
         //   scheduleUserControl11.Hide();
         //   emergency_StopUserControl11.Hide();
         //   setup_DataUserControl11.Hide();
         //   users_UserControl11.Hide();
          //  web_SettingUserControl11.Hide();


          //  invoiceUserControl11.Show();
         //   invoiceUserControl11.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Schedule
          //  doctorUserControl11.Hide();
         //   userControl1Dashboard1.Hide();
         //   userControl2patient1.Hide();
         //   appoinmentUserControl11.Hide();
         //   prescriptionUserControl11.Hide();

          //  paymentUserControl11.Hide();
          //  invoiceUserControl11.Hide();
            
          //  emergency_StopUserControl11.Hide();
          //  setup_DataUserControl11.Hide();
         //   users_UserControl11.Hide();
          //  web_SettingUserControl11.Hide();

         //   scheduleUserControl11.Show();
         //   scheduleUserControl11.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Emergency Stop
          //  doctorUserControl11.Hide();
          //  userControl1Dashboard1.Hide();
          //  userControl2patient1.Hide();
          //  appoinmentUserControl11.Hide();
          //  prescriptionUserControl11.Hide();

         //   paymentUserControl11.Hide();
         //   invoiceUserControl11.Hide();
          //  scheduleUserControl11.Hide();
            
           // setup_DataUserControl11.Hide();
          //  users_UserControl11.Hide();
          //  web_SettingUserControl11.Hide();

          //  emergency_StopUserControl11.Show();
          //  emergency_StopUserControl11.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Setup Data
         //   doctorUserControl11.Hide();
          //  userControl1Dashboard1.Hide();
         //   userControl2patient1.Hide();
        //    appoinmentUserControl11.Hide();
          //  prescriptionUserControl11.Hide();

          //  paymentUserControl11.Hide();
          //  invoiceUserControl11.Hide();
          //  scheduleUserControl11.Hide();
          //  emergency_StopUserControl11.Hide();
            
          //  users_UserControl11.Hide();
         //   web_SettingUserControl11.Hide();

          //  setup_DataUserControl11.Show();
          //  setup_DataUserControl11.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //User
           // doctorUserControl11.Hide();
           // userControl1Dashboard1.Hide();
           // userControl2patient1.Hide();
          //  appoinmentUserControl11.Hide();
          //  prescriptionUserControl11.Hide();

           // paymentUserControl11.Hide();
          //  invoiceUserControl11.Hide();
         //   scheduleUserControl11.Hide();
         //   emergency_StopUserControl11.Hide();
         //   setup_DataUserControl11.Hide();
            
          //  web_SettingUserControl11.Hide();

         //   users_UserControl11.Show();
          //  users_UserControl11.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Web Setting
           // doctorUserControl11.Hide();
           // userControl1Dashboard1.Hide();
           // userControl2patient1.Hide();
          //  appoinmentUserControl11.Hide();
          //  prescriptionUserControl11.Hide();

         //   paymentUserControl11.Hide();
         //   invoiceUserControl11.Hide();
         //   scheduleUserControl11.Hide();
         //   emergency_StopUserControl11.Hide();
          //  setup_DataUserControl11.Hide();
          //  users_UserControl11.Hide();
            

           // web_SettingUserControl11.Show();
          //  web_SettingUserControl11.BringToFront();
        }

        private void web_SettingUserControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl1Dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
