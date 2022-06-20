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
    public partial class Frm_M15_CTV : Form
    {
        public Frm_M15_CTV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100;
            MessageBox.Show(a.ToString());
            int b = a;
            MessageBox.Show("a："+a.ToString() + "\nb："+b.ToString());
            b = 200;
            MessageBox.Show("a：" + a.ToString() + "\nb：" + b.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox tb = TxtRefrenceType;
            tb.Text = "Refrence Type GOGOGO";
            tb.BackColor = Color.LightPink;

        }
    }
}
