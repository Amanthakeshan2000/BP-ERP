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
    public partial class UserControl1Dashboard : UserControl
    {


        //public static UserControl1Dashboard instance;

        public UserControl1Dashboard()
        {
            InitializeComponent();
           // instance = this;
        }

        private void UserControl1Dashboard_Load(object sender, EventArgs e)
        {
            label9.Text = Class1.uame;
        }
    }
}
