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
    public partial class frmP16 : Form
    {
        public frmP16()
        {
            InitializeComponent();
        }

        private void frmP16_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP15 p15 = new frmP15();
            this.Dispose();
            p15.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP17 p17 = new frmP17();
            this.Dispose();
            p17.ShowDialog();
        }

        private void rbt_40sim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_40sim.Checked)
                txb_40a.Enabled = true;
        }

        private void rbt_40nao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_40nao.Checked)
                txb_40a.Enabled = false;
        }
    }
}
