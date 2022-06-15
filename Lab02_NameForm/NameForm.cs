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
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        private void ButName_Click(object sender, EventArgs e)
        {
            string Name = TboxName.Text;
            MessageBox.Show("Hello!" + Name);
        }

        private void NameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
