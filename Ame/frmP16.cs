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
    public partial class frmP16 : Form
    {
        public frmP16(FichaBebeTresMeses fichaBebeTresMeses, SobrePais sobrePais)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.SobrePais = sobrePais;
            txb_39.Text = SobrePais.Pergunta39;
            txb_40a.Text = SobrePais.Pergunta40;
            switch (SobrePais.Pergunta40v1)
            {
                case "sim": rbt_40bSim.Checked = true; break;
                case "nao": rbt_40bNao.Checked = true; break;
            }
        }

        private void frmP16_Load(object sender, EventArgs e)
        {

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.SobrePais.Pergunta39 = txb_39.Text;
            this.SobrePais.Pergunta40 = txb_40a.Text;
            frmP15 p15 = new frmP15(this.Ficha, this.SobrePais);
            this.Dispose();
            p15.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<SobrePais>(context);
            if (!Consulta.Consultar(new List<String>() { txb_39.Text, txb_40a.Text, this.SobrePais.Pergunta40v1!}))
            {
                this.SobrePais.Pergunta39 = txb_39.Text;
                this.SobrePais.Pergunta40 = txb_40a.Text;
                dal.Alterar(this.SobrePais);
                frmP17 p17 = new frmP17(this.Ficha, this.SobrePais);
                this.Dispose();
                p17.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void rbt_40sim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_40sim.Checked)
            {
                txb_40a.Text = txb_40a.Text.Equals(Consulta.Empty) ? String.Empty : this.SobrePais.Pergunta40;
                txb_40a.Enabled = true;
            }
        }

        private void rbt_40nao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_40nao.Checked)
            {
                txb_40a.Text = Consulta.Empty;
                txb_40a.Enabled = false;
            }
        }

        private void rbt_40bSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_40bSim.Checked)
                this.SobrePais.Pergunta40v1 = "sim";
        }

        private void rbt_40bNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_40bNao.Checked)
                this.SobrePais.Pergunta40v1 = "nao";
        }
    }
}
