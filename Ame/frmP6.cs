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
    public partial class frmP6 : Form
    {
        public frmP6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmP5 p5 = new frmP5();
            this.Dispose();
            p5.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP7 p7 = new frmP7();
            this.Dispose();
            p7.ShowDialog();

        }

        private void rbt_simSuplementacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim12.Checked)
                txb_suplementacao.Enabled = true;
        }

        private void rbt_naoSuplementacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao12.Checked)
                txb_suplementacao.Enabled = false;

        }

        private void rbt_simProblemaRespiracao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim13.Checked)
                txb_problemaRespiracao.Enabled = true;
        }

        private void rbt_naoProblemaRespiracao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao13.Checked)
                txb_problemaRespiracao.Enabled = false;
        }
    }
}
