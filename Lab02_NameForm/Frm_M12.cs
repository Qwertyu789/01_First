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
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();
        }
        int c = 0;
        private void CounterBtn_Click(object sender, EventArgs e)
        {
            c += 1;
            CounterLB.Text = "Count：" + c;
        }

        private void frontadd_Click(object sender, EventArgs e)
        {
            int b = c++;
            CounterLB.Text = "Count：" + c;
            MessageBox.Show(Convert.ToString(b));
        }

        private void backadd_Click(object sender, EventArgs e)
        {
            int b = ++c;
            CounterLB.Text = "Count：" + c;
            MessageBox.Show(Convert.ToString(b));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (true)
            {
                int x = 99;
                c += 2;
                a = c++;
            }
             c  += 1;
            CounterLB.Text = "Count：" + c;
            MessageBox.Show(Convert.ToString(a));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c += 1;
            CounterLB.Text = "Count：" + c;
        }

        UseStatic us = new UseStatic();

        private void button4_Click(object sender, EventArgs e)
        {
            us.InstanceCount++;
            InstanceCountLB.Text = "Instance Count：" + us.InstanceCount;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UseStatic.StaticCount++;
            StaticCountLB.Text = "Static Count：" + UseStatic.StaticCount;
        }

        private void FrmHelloCallBut_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm hello = new Frm_M02_HelloForm();
            hello.Show();
        }
    }
}
