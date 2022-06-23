using System;
using System.Collections;
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
    public partial class Frm_M29_集合 : Form
    {
        public Frm_M29_集合()
        {
            InitializeComponent();
        }

        void Employeelist()
        {
            label3.Text = "員員：\n";

            for (int i = 0; i < isEmp.Count; i++)
            {
                label3.Text += $"姓名：{((employee)isEmp[i]).Name}" + $"　　年齡：{((employee)isEmp[i]).Age}\n";
            }
            label3.Text += $"------------------------\n員工總數：{isEmp.Count}";
        }

        ArrayList isEmp =new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            employee emp;
            emp.Name = textBox1.Text;
            emp.Age = int.Parse(textBox2.Text);

            //封箱
            isEmp.Add(emp);
            Employeelist();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isEmp.Clear();
            Employeelist();
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            employee emp;
            emp.Name = textBox1.Text;
            emp.Age = int.Parse(textBox2.Text);
            isEmp.Insert(0, emp);
            Employeelist();
        }

        private void butRemoveat_Click(object sender, EventArgs e)
        {
            isEmp.RemoveAt(0);
            Employeelist();
        }
    }
}
