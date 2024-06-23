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
    public partial class frmP8 : Form
    {
        public frmP8(FichaBebeTresMeses fichaBebeTresMeses, NivelDeAtividade nivelDeAtividade)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.NivelDeAtividade = nivelDeAtividade;
            txt_16.Text = NivelDeAtividade.Pergunta16;
            txt_18.Text = NivelDeAtividade.Pergunta18;
            txt_19.Text = NivelDeAtividade.Pergunta19;
            switch (NivelDeAtividade.Pergunta17)
            {
                case "sim":rbt_sim17.Checked = true; break;
                case "nao":rbt_nao17.Checked = true; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.NivelDeAtividade.Pergunta16 = txt_16.Text;
            this.NivelDeAtividade.Pergunta18 = txt_18.Text;
            this.NivelDeAtividade.Pergunta19 = txt_19.Text;
            frmP7 p7 = new frmP7(this.Ficha, this.NivelDeAtividade);
            this.Dispose();
            p7.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new BD_Context();
            var dal = new DAL<NivelDeAtividade>(context);
            if (!Consulta.Consultar(new List<string>() { txt_16.Text, this.NivelDeAtividade.Pergunta17!, txt_18.Text, txt_19.Text }))
            {
                this.NivelDeAtividade.Pergunta16 = txt_16.Text;
                this.NivelDeAtividade.Pergunta18 = txt_18.Text;
                this.NivelDeAtividade.Pergunta19 = txt_19.Text;
                dal.Alterar(this.NivelDeAtividade);
                frmP9 p9 = new frmP9(this.Ficha, this.NivelDeAtividade);
                this.Dispose();
                p9.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbt_simAssisteTela_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim17.Checked)
            {
                this.NivelDeAtividade.Pergunta17 = "sim";
                txt_19.Text = txt_19.Text.Equals(Consulta.Empty) ? String.Empty : this.NivelDeAtividade.Pergunta19;
                txt_19.Enabled = true;
                txt_18.Text = txt_18.Text.Equals(Consulta.Empty) ? String.Empty : this.NivelDeAtividade.Pergunta18;
                txt_18.Enabled = true;
            }
        }

        private void rbt_naoAssisteTela_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao17.Checked)
            {
                this.NivelDeAtividade.Pergunta17 = "nao";
                txt_18.Enabled = false;
                txt_18.Text = Consulta.Empty;
                txt_19.Enabled = false;
                txt_19.Text = Consulta.Empty;
            }
        }
    }
}
