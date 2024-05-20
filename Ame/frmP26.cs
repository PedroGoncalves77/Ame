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
    public partial class frmP26 : Form
    {
        public frmP26()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP25 p25 = new frmP25();
            this.Dispose();
            p25.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP27 p27 = new frmP27();
            this.Dispose();
            p27.ShowDialog();
        }

        private void frmP26_Load(object sender, EventArgs e)
        {

        }

        private void rbt_sim66_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbt_nao66_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
