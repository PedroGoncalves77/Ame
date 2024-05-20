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
    public partial class frmP2 : Form
    {
        public frmP2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmP1 p1 = new frmP1();
            this.Dispose();
            p1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP3 p3 = new frmP3();
            this.Dispose();
            p3.ShowDialog();
            
        }
    }
}
