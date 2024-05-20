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
    public partial class frmP23 : Form
    {
        public frmP23()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP22 p22 = new frmP22();
            this.Dispose();
            p22.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP24 p24 = new frmP24();
            this.Dispose();
            p24.ShowDialog();
        }
    }
}
