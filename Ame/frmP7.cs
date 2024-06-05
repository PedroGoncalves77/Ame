using Ame.BD;
using Ame.Modelo;
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
    public partial class frmP7 : Form
    {
        public frmP7(FichaBebeTresMeses ficha)
        {
            InitializeComponent();
            this.Ficha = ficha;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var crianca = this.Ficha.SaudeCrianca.ToList();
            var cri = crianca.Last();
            var context = new BD_Context();
            var dal = new DAL<FichaBebeTresMeses>(context);
            frmP6 p6 = new frmP6(this.Ficha, cri!);
            this.Dispose();
            p6.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP8 p8 = new frmP8();
            this.Dispose();
            p8.ShowDialog();
            
        }

        private void lbl_4_Click(object sender, EventArgs e)
        {

        }

        private void rbt_simExposicaoLuz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim14.Checked)
                txb_exposicaoLuz.Enabled = true;
        }

        private void rbt_naoExposicaoLuz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao14.Checked)
                txb_exposicaoLuz.Enabled = false;
        }

        private void rbt_simBebeAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim15.Checked)
                txb_bebeAtivo.Enabled = true;
        }

        private void rbt_naoBebeAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao15.Checked)
                txb_bebeAtivo.Enabled = false;
        }
    }
}
