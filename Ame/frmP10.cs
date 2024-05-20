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
    public partial class frmP10 : Form
    {
        public frmP10()
        {
            InitializeComponent();
        }

        private void frmP10_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP9 p9 = new frmP9();
            this.Dispose();
            p9.ShowDialog();

        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP11 p11 = new frmP11();
            this.Dispose();
            p11.ShowDialog();
        }

        private void rbt_sim22_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim22.Checked)
                txt_22.Enabled = true;
        }

        private void rbt_nao22_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao22.Checked)
                txt_22.Enabled = false;
        }

        private void rbt_sim24_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim24.Checked)
                txt_24.Enabled = true;
        }

        private void rbt_nao24_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao24.Checked)
                txt_24.Enabled = false;
        }

        private void rbt_sim25_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim25.Checked)
                txt_25.Enabled = true;
        }

        private void rbt_nao25_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao25.Checked)
                txt_25.Enabled = false;
        }
    }
}
