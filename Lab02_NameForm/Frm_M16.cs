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
    public partial class Frm_M16 : Form
    {
        public Frm_M16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal dec = 10;
            MessageBox.Show(dec.ToString());
            byValueType(dec);
            MessageBox.Show(dec.ToString());
        }

        void byValueType(decimal d)
        {
            d = 1000;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "Rika";
            mem1.Age = 12;
            MessageBox.Show((mem1.Age).ToString());
            byReferenceType(mem1);
            MessageBox.Show((mem1.Age).ToString());
        }

        void byReferenceType(Member member)
        {
            member.Age = 18;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal Dec = 10;
            byRef(ref Dec);
            MessageBox.Show(Dec.ToString());
        }

        void byRef (ref decimal d)
        {
            d = 1000;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            byOut(out a);
            MessageBox.Show(a.ToString());
        }

        void byOut (out int Age)
        {
            Age = 10000;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cht = byParams("國文", 30, 60, 90, 100);
            MessageBox.Show(cht);
            string math = byParams("數學", 10,20,30);
            MessageBox.Show(math);
            string eng = byParams("英文");
            MessageBox.Show(eng);
        }

        string byParams (string Course,params int[] scores)
        {
            int total = 0;
            for (int i = 0; i<scores.Length; i++)
            {
                total += scores[i];
            }
            return Course + "的總分為：" + total;
        }
    }
}
