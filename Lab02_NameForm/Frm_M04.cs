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

        private void classmethod_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            mc.method02();
            mc.method03();
        }
        String Birthday(int Age)
        {
            int birthday = DateTime.Now.Year - Age;
            string result = ("你的出生年為 " + birthday + " 年");
            return result;
        }

        private void BirdayBut_Click(object sender, EventArgs e)
        {
            int year = 0;
            try { year = Convert.ToInt32(BirthYearTB.Text); } catch { }
            MessageBox.Show(Birthday(year));
            
        }

        private void ESTestBut_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            mc.method04();
        }

        private void PartialBut_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            mc.method06();
        }
    }
}
