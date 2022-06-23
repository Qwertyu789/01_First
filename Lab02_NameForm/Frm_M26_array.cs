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
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            string s = "";
            //for (int i = 0; i < 3; i++)
            //{
            //    s += arr[i] + "\n";
            //}
            foreach(int i in arr)
            {
                s += i+ "\n";
            }
            MessageBox.Show(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[3, 2];
            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[1, 0] = 3;
            arr[1, 1] = 4;
            arr[2, 0] = 5;
            arr[2, 1] = 6;

            string s = "";
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int n = 0; n < arr.GetLength(1); n++)
            //    {
            //        s += $"arr[{ i} ,{ n}] ={ arr[i, n]} \n";
            //    }
            //}

            

            foreach(int i in arr)
            {
                s += $"{ i} \n";
            }

            MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "";
            int[] intarr = CreatArray(20);

            //for(int i = 0; i < intarr.Length; i++)
            //{
            //    s += $"intarr[{i}]= {intarr[i]} \n";
            //}

            foreach(int item in intarr)
            {
                s += $"{item} \n";
            }

            MessageBox.Show(s);

        }
        int[] CreatArray(int lenth)
        {
            int[] arr = new int[lenth];
            int i = 0;
            for (; i < arr.Length; )
            {
                arr[i] = ++i;
            }
            return arr;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Member[] arrMember = new Member[2];
            //arrMember[0] = new Member();
            //arrMember[0].Name = "789";
            //arrMember[0].Age = 26;
            //arrMember[1] = new Member();
            //arrMember[1].Name = "Peanut";
            //arrMember[1].Age = 27;

            //Member mem1 = new Member() { Name = "789", Age = 26 };
            //Member mem2 = new Member() { Name = "Peanut", Age = 27 };
            //Member[] arrMember = new Member[2] { mem1, mem2 };

            Member[] arrMember =
            {
                new Member() {Name="789",Age=26 },
                new Member() {Name="Peanut",Age=27 }
            };

            MessageBox.Show($"Name：{arrMember[0].Name}，Age：{arrMember[0].Age}");
        }
    }
    
}
