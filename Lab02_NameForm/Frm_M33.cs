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
    public partial class Frm_M33 : Form
    {
        public Frm_M33()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "哭啊喊啊，叫你媽媽帶你去買玩具啊";
            char c = str[3];
            MessageBox.Show(c.ToString());
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += str[i] + "\n"; 
            }
            MessageBox.Show(result);
            result = "";
            foreach(char item in str)
            {
                result += item + "\n";
            }
            MessageBox.Show(result);
        }
    }
}
