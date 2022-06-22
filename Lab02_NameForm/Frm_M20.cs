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
    public partial class Frm_M20 : Form
    {
        bool re0 = true;
        public Frm_M20()
        {
            InitializeComponent();
        }               
        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = re0 ? Color.Black : Color.White;
            re0 = !re0;
        }

        private void butScore_Click(object sender, EventArgs e)
        {
            /*
            90~100 S
            80~89  A
            70~79  B
            60~69  C
            ~59    E
            */
            int Score = 0;
            bool isNum = int.TryParse(tbScore.Text,out Score);
            if (isNum)
            {
                if (Score > 100)
                {
                    DialogResult result = MessageBox.Show("你怎麼連登記成績都要作弊", "人格還好嗎？", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    tbScore.Clear();
                    tbScore.Focus();
                }
                else if (Score >= 90)
                    lbGrade.Text = "你獲得 S 評價";
                else if (Score >= 80)
                    lbGrade.Text = "你獲得 A 評價";
                else if (Score >= 70)
                    lbGrade.Text = "你獲得 B 評價";
                else if (Score >= 60)
                    lbGrade.Text = "你獲得 C 評價";
                else if (Score <59 && Score >=0)
                    lbGrade.Text = "E級仔 \n你獲得 明年再來門票";
            }
            else {
                DialogResult result = MessageBox.Show("你怎麼連數字都不會打", "腦子還好嗎？", MessageBoxButtons.OK, MessageBoxIcon.Question);
                tbScore.Clear();
                tbScore.Focus();
            }
        }

        private void btnCase_Click(object sender, EventArgs e)
        {
            DialogResult dateresult =  MessageBox.Show("今天星期三嗎", "今天星期幾？", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch(dateresult)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Yes");
                    break;
                case DialogResult.No:
                    MessageBox.Show("No");
                    break;
                default:
                    MessageBox.Show("???");
                    break;

            }
        }

        private void butWhile_Click(object sender, EventArgs e)
        {
            //While Loop =前測式，會先做判斷才進計算，每跑一次做一次判斷。
            int i=1;
            string s = "";
            while (i <= 10)
            {
                s += i+"\n";
                i++;
            }
            MessageBox.Show(s);
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            // Do Loop = 後測式，會先跑一輪計算才進While判斷
            int i = 10;
            string s = "";
            do
            {
                s += i + "\n";
                i--;
            } while (i < 10 && i>=0);
            MessageBox.Show(s);
        }

        private void butForLoop_Click(object sender, EventArgs e)
        {
            //string s = "";
            //for(int i = 0; i < 10; i++)
            //{
            //    s += i + "\n";
            //}
            //MessageBox.Show(s);
            string y = "";
            for(int i =0,x = 10, z = 5; i <= x + z; i += 2, z++)
            {
                y += $" i = {i,3} |"+$" x = {x,3} |"+$" z = {z,3} |\n";
            }
            MessageBox.Show(y);
        }
    }
}
