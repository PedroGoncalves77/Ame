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
    public partial class frmP28 : Form
    {
        public frmP28(FichaBebeTresMeses fichaBebeTresMeses, AmbienteSono ambienteSono)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.AmbienteSono = ambienteSono;
            txt_74.Text = AmbienteSono.Pergunta74;
            switch (AmbienteSono.Pergunta75)
            {
                case "sim": rbt_sim75.Checked = true; break;
                case "nao": rbt_nao75.Checked = true; break;
            }
            switch (AmbienteSono.Pergunta76)
            {
                case "sim": rbt_sim76.Checked = true; break;
                case "nao": rbt_nao76.Checked = true; break;
            }
            switch (AmbienteSono.Pergunta77)
            {
                case "sim": rbt_sim77.Checked = true; break;
                case "nao": rbt_nao77.Checked = true; break;
            }
            switch (AmbienteSono.Pergunta78)
            {
                case "claro": rbt_claro78.Checked = true; break;
                case "penumbra": rbt_penumbra78.Checked = true; break;
                case "escuro": rbt_escuro78.Checked = true; break;
            }
            switch (AmbienteSono.Pergunta79)
            {
                case "dia": rbt_dia79.Checked = true; break;
                case "noite": rbt_noite79.Checked = true; break;
                case "ambos": rbt_ambos79.Checked = true; break;
            }


        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {   
            using var context = new BD_Context();
            var dal = new DAL<AmbienteSono>(context);
            this.AmbienteSono.Pergunta74 = txt_74.Text;
            dal.Alterar(this.AmbienteSono);
            frmP27 p27 = new frmP27(this.Ficha, this.Ficha.ProblemaSono.ToList().Last());
            this.Dispose();
            p27.ShowDialog();

        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if (!Consulta.Consultar(new List<string>() {txt_74.Text, this.AmbienteSono.Pergunta75!, this.AmbienteSono.Pergunta76!, 
                this.AmbienteSono.Pergunta77!,this.AmbienteSono.Pergunta78!,this.AmbienteSono.Pergunta79!}))
            {
                this.AmbienteSono.Pergunta74 = txt_74.Text;
                frmP29 p29 = new frmP29(this.Ficha, this.AmbienteSono);
                this.Dispose();
                p29.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void rbt_sim74_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim74.Checked)
            {
                txt_74.Text = txt_74.Text.Equals(Consulta.Empty) ? String.Empty : this.AmbienteSono.Pergunta74;
                txt_74.Enabled = true;
            }
        }

        private void rbt_nao74_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao74.Checked)
            {
                txt_74.Text = Consulta.Empty;
                txt_74.Enabled = false;
            }
        }

        private void rbt_sim75_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim75.Checked)
                this.AmbienteSono.Pergunta75 = "sim";
        }

        private void rbt_nao75_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao75.Checked)
                this.AmbienteSono.Pergunta75 = "nao";
        }

        private void rbt_sim76_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim76.Checked)
                this.AmbienteSono.Pergunta76 = "sim";
        }

        private void rbt_nao76_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao76.Checked)
                this.AmbienteSono.Pergunta76 = "nao";
        }

        private void rbt_sim77_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim77.Checked)
                this.AmbienteSono.Pergunta77 = "sim";
        }

        private void rbt_nao77_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao77.Checked)
                this.AmbienteSono.Pergunta77 = "nao";
        }

        private void rbt_claro78_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_claro78.Checked)
                this.AmbienteSono.Pergunta78 = "claro";
        }

        private void rbt_penumbra78_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_penumbra78.Checked)
                this.AmbienteSono.Pergunta78 = "penumbra";
        }

        private void rbt_escuro78_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_escuro78.Checked)
                this.AmbienteSono.Pergunta78 = "escuro";
        }

        private void rbt_dia79_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_dia79.Checked)
                this.AmbienteSono.Pergunta79 = "dia";
        }

        private void rbt_noite79_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_noite79.Checked)
                this.AmbienteSono.Pergunta79 = "noite";
        }

        private void rbt_ambos79_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_ambos79.Checked)
                this.AmbienteSono.Pergunta79 = "ambos";
        }
    }
}
