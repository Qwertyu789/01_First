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
    public partial class Frm_M19_Struct : Form
    {
        public Frm_M19_Struct()
        {
            InitializeComponent();
        }

        string productresult="產品一覽：";
        //計數器
        int n = 0;
        //總金額計萬
        decimal totalPrice = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            //product pro;
            //pro.Productname = tbName.Text;
            //pro.Productprice = decimal.Parse(tbPrice.Text);
            //productresult += "\n名稱：" + pro.Productname + " 單價：" + pro.Productprice;
            //autoPush();

            decimal price = 0;
            bool isNum = decimal.TryParse(tbPrice.Text, out price);
            if (isNum) 
            {
                product pro = new product(tbName.Text, price);
                totalPrice += pro.Productprice;
                productresult += $"\n名稱：{pro.Productname} ，單價：{pro.Productprice:c0}";
                n += 1;
            }
            else
            {
                MessageBox.Show("請輸入數字！！！！！！！！！！！！！！");
                tbPrice.Clear();
                tbPrice.Focus();
            }
            
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            //labProduct.Text = productresult;
            //labInfo.Text = "總覽"+"\n產品種類：" + n + " 總金額：" + totalPrice;
            labProduct.Text = $"{productresult} \n--------------------- \n總數量：{n} ，總金額：{totalPrice:c0}" +
                $"\n商品均價{totalPrice / n:c0}";
          
        }
        //自動PUSH 
        //void autoPush()
        //{
        //    labProduct.Text = productresult;
        //    labInfo.Text = "總覽" + "\n產品種類：" + n + " 總金額：" + totalPrice;
        //}
    }
}
