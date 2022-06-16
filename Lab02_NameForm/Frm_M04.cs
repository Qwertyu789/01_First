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
    public partial class Frm_M04 : Form
    {
        public Frm_M04()
        {
            InitializeComponent();

            
        }

        private void OpnHelloForm_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm HelloForm = new Frm_M02_HelloForm();

            HelloForm.Show();
        }

        void myfirstmethod()
        {
            MessageBox.Show("My first Method！！");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myfirstmethod();
        }
    }
}
