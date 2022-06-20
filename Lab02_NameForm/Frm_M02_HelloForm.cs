using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace Lab02_NameForm
{
    public partial class Frm_M02_HelloForm : Form
    {
        public Frm_M02_HelloForm()
        {
            InitializeComponent();
        }

        private void ButName_Click(object sender, EventArgs e)
        {
            string Name = TboxName.Text;
            MessageBox.Show("Hello！" + Name+" 同學\r準備好放棄了嗎？");
            MessageBox.Show(UseStatic.StaticCount.ToString());

        }


    }
}
