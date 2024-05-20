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
    public partial class frmP22 : Form
    {
        public frmP22()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP21 p21 = new frmP21();
            this.Dispose();
            p21.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP23 p23 = new frmP23();
            this.Dispose();
            p23.ShowDialog();
        }
    }
}
