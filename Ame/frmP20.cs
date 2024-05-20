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
    public partial class frmP20 : Form
    {
        public frmP20()
        {
            InitializeComponent();
        }

        private void lbl_45_Click(object sender, EventArgs e)
        {

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP19 p19 = new frmP19();
            this.Dispose();
            p19.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP21 p21 = new frmP21();
            this.Dispose();
            p21.ShowDialog();
        }

        private void txt_50_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
