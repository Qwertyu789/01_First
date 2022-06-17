using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_NameForm
{
    public partial class MyFirstClass
    {
     private void method01() { MessageBox.Show("private method"); }
     public void method02() { MessageBox.Show("public method"); }
     internal void method03() { MessageBox.Show("internal method"); }
     public void method04() {
            method01();
        }
    }
}
