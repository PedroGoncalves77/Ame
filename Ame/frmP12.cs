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
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void rbt_naoChoro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao32.Checked)
                txb_32.Enabled = false;
        }

        private void rbt_naoAgitado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao33.Checked)
                txt_33.Enabled = false;
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP11 p11 = new frmP11();
            this.Dispose();
            p11.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP13 p13 = new frmP13();
            this.Dispose();
            p13.ShowDialog();
        }

        private void rbt_sim32_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim32.Checked)
                txb_32.Enabled = true;
        }

        private void rbt_sim33_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim33.Checked)
                txt_33.Enabled = true;
        }
    }
}
