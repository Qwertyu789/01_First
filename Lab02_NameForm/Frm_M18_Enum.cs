using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_NameForm
{
    public partial class Frm_M18_Enum : Form
    {
        public Frm_M18_Enum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRole Role = UserRole.Admin;
            //if (Role == UserRole.Admin)
            //{
            //    ProductBtn.Enabled = true;
            //}
            //else
            //{
            //    ProductBtn.Enabled = false;
            //    }

            ProductBtn.Enabled = Role == UserRole.Admin;
            

        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("不可以瑟瑟！");
        }
    }
}
