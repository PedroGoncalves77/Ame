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
    public partial class frmP5 : Form
    {
        public frmP5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmP4 p4 = new frmP4();
            this.Dispose();
            p4.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP6 p6 = new frmP6();
            this.Dispose();
            p6.ShowDialog();

        }

        private void rbt_naoCongestao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_naoCongestao.Checked)
                txb_congestao.Enabled = false;
        }

        private void lbl_4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DorOuvido_Click(object sender, EventArgs e)
        {

        }

        private void rbt_naoAlergia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_naoAlergia.Checked)
                txb_alergia.Enabled = false;
        }

        private void rbt_simCongestao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_simCongestao.Checked)
                txb_congestao.Enabled = true;
        }

        private void rbt_naoIntestino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_naoIntestino.Checked)
                txb_Intestino.Enabled = false;
        }

        private void rbt_simAlergia_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbt_simAlergia.Checked)
                txb_alergia.Enabled = true;

        }

        private void rbt_simIntestino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_simIntestino.Checked)
                txb_Intestino.Enabled = true;
        }
    }
}
