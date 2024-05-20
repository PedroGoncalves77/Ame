using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ame
{
    public partial class frmP9 : Form
    {
        public frmP9()
        {
            InitializeComponent();
        }

        private void lbl_3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmP8 p8 = new frmP8();
            this.Dispose();
            p8.ShowDialog();
;        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP10 p10= new frmP10();
            this.Dispose();
            p10.ShowDialog();
        }
    }
}
