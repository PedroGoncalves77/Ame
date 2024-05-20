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
    public partial class frmP19 : Form
    {
        public frmP19()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP18 p18 = new frmP18();
            this.Dispose();
            p18.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP20 p20 = new frmP20();
            this.Dispose();
            p20.ShowDialog();
        }

        private void rbt_sim47_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim47.Checked)
                txt_47a.Enabled = true;
                txt_47b.Enabled = true;
                txt_47c.Enabled = true;
        }

        private void rbt_nao47_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao47.Checked)
                txt_47a.Enabled = false;
                txt_47b.Enabled = false;
                txt_47c.Enabled = false;
        }
    }
}
