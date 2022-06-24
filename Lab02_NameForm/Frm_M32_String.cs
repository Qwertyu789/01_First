using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_NameForm
{
    public partial class Frm_M32_String : Form
    {
        public Frm_M32_String()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //不會改變原StringA的內容 因建立不同記憶體槽區
            String A = "AAA";
            String B = A;
            B = "BBB";
            MessageBox.Show("A：" + A + "\nB：" + B);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //會改變原SB1的內容 
            StringBuilder SB1 = new StringBuilder();
            SB1.Append("sb 1");
            StringBuilder SB2 = new StringBuilder();
            SB2 = SB1;
            SB2.Append("\nsb 2");
            MessageBox.Show(SB1.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String dir = @"C:\Users\Student\source\repos\01_First\ASSKIRITO.gif";
            string result = "";
            result +=
                Path.GetDirectoryName(dir) + "\n" +
                Path.GetExtension(dir) + "\n" +
                Path.GetFileName(dir) + "\n" +
                Path.GetFullPath(dir) + "\n";
            MessageBox.Show(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = IsPwStrong(textBox1.Text) ? "密碼強度高" : "密碼強度低";
            label2.Text = IsIDRight(textBox2.Text) ? "身分字號格式正確" : "身分字號格式錯誤";
        }
        bool IsPwStrong(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$");
        }
        bool IsIDRight(string ID)
        {
            return Regex.IsMatch(ID, @"^[A-Z]{1}[1-2]{1}[0-9]{8}&");
        }
    }
}
