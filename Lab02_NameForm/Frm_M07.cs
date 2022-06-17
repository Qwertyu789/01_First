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
    }
}
