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
    public partial class frmP3 : Form
    {
        public frmP3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmP2 p2 = new frmP2();
            this.Dispose();
            p2.ShowDialog();
            //this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP4 p4 = new frmP4();
            this.Dispose();
            p4.ShowDialog();
            
        }

        private void lbl_3_Click(object sender, EventArgs e)
        {

        }
    }
}
