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
    public partial class Frm_M30_泛用集合List : Form
    {
        //property
        List<employee> isEmp = new List<employee>();
        public Frm_M30_泛用集合List()
        {
            InitializeComponent();
        }

        //----------------------------------------------------
        //method
        void Employeelist()
        {
            label3.Text = "員員：\n";

            //for (int i = 0; i < isEmp.Count; i++)
            //{
            //    label3.Text += $"姓名：{(isEmp[i]).Name}" + $"　　年齡：{(isEmp[i]).Age}\n";
            //}
            
            foreach (employee item in isEmp)
            {
                label3.Text += $"姓名：{item.Name}" + $"　　年齡：{item.Age}\n";
            }
            label3.Text += $"------------------------\n員工總數：{isEmp.Count}";


        }
    


        //----------------------------------------------------
        //function
        private void butAdd_Click(object sender, EventArgs e)
        {
            employee emp;
            emp.Name = textBox1.Text;
            emp.Age = int.Parse(textBox2.Text);

            //boxing
            isEmp.Add(emp);

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

        private void button3_Click(object sender, EventArgs e)
        {
            isEmp.Clear();
            Employeelist();
        }

        private void butRemoveat_Click(object sender, EventArgs e)
        {
            isEmp.RemoveAt(0);
            Employeelist();
        }
    }
}
