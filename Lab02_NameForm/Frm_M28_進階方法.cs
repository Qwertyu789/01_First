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
    public partial class Frm_M28_進階方法 : Form
    {
        public Frm_M28_進階方法()
        {
            InitializeComponent();
        }

        void swap(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        void swap (ref string x,ref string y)
        {
            string z = x;
            x = y;
            y = z;
        }

        void GenericSwap<AA>(ref AA G,ref AA Y)
        {
            AA O = G;
            G = Y;
            Y = O;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int A = 100, B = 200;
            MessageBox.Show(A+","+B);
            swap(ref A,ref B);
            MessageBox.Show(A + "," + B);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string X = "哈哈", Y = "屁眼派對";
            MessageBox.Show(X + "," + Y);
            swap(ref X, ref Y );
            MessageBox.Show(X + "," + Y);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int X = 789,Y = 9487;
            GenericSwap<int>(ref X, ref Y);
            MessageBox.Show(X + "," + Y);
            string T = "大聲喊出超能力", W = "島輝";
            GenericSwap<string>(ref T, ref W);
            MessageBox.Show(T + "," + W);

        }
    }
}
