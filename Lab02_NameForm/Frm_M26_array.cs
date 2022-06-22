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
    public partial class Frm_M26_array : Form
    {
        public Frm_M26_array()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            int[] arr = new int [3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            string s = "";
            for(int i=0; i<3; i++)
            {
                s += arr[i]+ "\n";
            }
            MessageBox.Show(s);
        }
    }
}
