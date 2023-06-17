using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPERP
{
    public partial class AppoinmentUserControl1 : UserControl
    {
        public AppoinmentUserControl1()
        {
            InitializeComponent();
        }

        private void AppoinmentUserControl1_Load(object sender, EventArgs e)
        {
            _2_appoinmentListUserControl11.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2_appoinmentListUserControl11.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _2_appoinmentListUserControl11.Show();
            _2_appoinmentListUserControl11.BringToFront();
        }
    }
}
