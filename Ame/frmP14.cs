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
    public partial class frmP14 : Form
    {
        public frmP14()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP13 p13 = new frmP13();
            this.Dispose();
            p13.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP15 p15 = new frmP15();
            this.Dispose();
            p15.ShowDialog();
        }
    }
}
