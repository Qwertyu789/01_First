using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_NameForm
{
    public partial class Frm_M34_StreamReader : Form
    {
        public Frm_M34_StreamReader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader strRead = new StreamReader("GodTon.txt", Encoding.UTF8);
            textBox1.Text = strRead.ReadToEnd();
            strRead.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\GodTonTon.txt", FileMode.Create);
            StreamWriter strwrite = new StreamWriter(fs, Encoding.Default);
            strwrite.Write(textBox1.Text);
            strwrite.Close();
            fs.Close();
        }
    }
}
