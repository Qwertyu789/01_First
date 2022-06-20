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
    public partial class Frm_M07 : Form
    {
        public Frm_M07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "張仕旻";
            mem1.Age = 26;

            MessageBox.Show("姓名： "+ mem1.Name + "\n年齡： "+mem1.Age);

            Member mem2 = new Member()
            {
                Name = "rick",
                Age = 99,
            };
            MessageBox.Show("姓名： " + mem2.Name + "\n年齡： " + mem2.Age);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            Register01But.Click += new EventHandler(Register01ButClick);
            Register02But.Click += Register02ButClick;
        }

        private void Register02ButClick(object sender, EventArgs e)
        {
            MessageBox.Show("Register02");
        }

        private void Register01ButClick(object sender, EventArgs e)
        {
            MessageBox.Show("Register01");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Register01But.Click -= new EventHandler(Register01ButClick);
        }

        private void RENAME_Click(object sender, EventArgs e)
        {
            Text = "HAHA";
        }

        private void moveBtn_Click(object sender, EventArgs e)
        {
            this.RENAME.SetBounds(200, 200, 100, 100);
        }

        private void MessageBoxAns_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("今天星期二嗎？", "回答我"
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("賓果答錯了，拉進垃圾車HEHE");
            }
            else if (result==DialogResult.No)
            {
                MessageBox.Show("賓果答對囉HEHE，福委加碼");
            }
            else
            {
                MessageBox.Show("這麼簡單YES NO問題都拒答，你媽不如生個西瓜");
            }
        }

        private void dialogresultBut_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm FrmHello = new Frm_M02_HelloForm();
            DialogResult result = FrmHello.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("讚ㄛ！");
            }
        }
    }
}
