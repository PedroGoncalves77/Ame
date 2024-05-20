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
    public partial class frmP21 : Form
    {
        public frmP21()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP20 p20 = new frmP20();
            this.Dispose();
            p20.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP22 p22 = new frmP22();
            this.Dispose();
            p22.ShowDialog();
        }
    }
}
