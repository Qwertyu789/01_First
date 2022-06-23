using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_NameForm
{
    partial class MyFirstClass
    {
        public void method06() { MessageBox.Show("partial class method"); }

    }
    public class Member
    {
        public string Name;
        public int Age;
        
    }
    public class UseStatic
    {
        public int InstanceCount;
        public static int StaticCount;

    } 

    public enum UserRole
    {
        Admin,
        User = 2
    }

    struct product
    {
        //public string Productname;
        //public decimal Productprice;

        public string Productname { get; set; }
        public decimal Productprice { get; set; }

        public product(string Name,decimal Price)
        {
            Productname = Name;
            Productprice = Price;
        }
    }

    struct employee
    {
        public string Name;
        public int Age;
    }
}
