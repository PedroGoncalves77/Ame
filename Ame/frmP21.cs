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
    public partial class frmP21 : Form
    {
        public frmP21(FichaBebeTresMeses fichaBebeTresMeses, DinamicaFamiliar dinamicaFamiliar)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.DinamicaFamiliar = dinamicaFamiliar;
            txt_51.Text = DinamicaFamiliar.Pergunta51;
            txt_52.Text = DinamicaFamiliar.Pergunta52;
            txt_53.Text = DinamicaFamiliar.Pergunta53;


        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.DinamicaFamiliar.Pergunta51 = txt_51.Text;
            this.DinamicaFamiliar.Pergunta52 = txt_52.Text;
            this.DinamicaFamiliar.Pergunta53 = txt_53.Text;
            frmP20 p20 = new frmP20(this.Ficha, this.DinamicaFamiliar);
            this.Dispose();
            p20.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if (!Consulta.Consultar(new List<string> { txt_51.Text, txt_52.Text, txt_53.Text }))
            {
                this.DinamicaFamiliar.Pergunta51 = txt_51.Text;
                this.DinamicaFamiliar.Pergunta52 = txt_52.Text;
                this.DinamicaFamiliar.Pergunta53 = txt_53.Text;
                frmP22 p22 = new frmP22(this.Ficha, this.DinamicaFamiliar);
                this.Dispose();
                p22.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void rbt_sim51_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim51.Checked)
            {
                txt_51.Text = txt_51.Text.Equals(Consulta.Empty) ? String.Empty : this.DinamicaFamiliar.Pergunta51;
                txt_51.Enabled = true;
            }
        }

        private void rbt_nao51_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao51.Checked)
            {
                txt_51.Text = Consulta.Empty;
                txt_51.Enabled = false;
            }
        }

        private void rbt_sim52_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim52.Checked)
            {
                txt_52.Text = txt_52.Text.Equals(Consulta.Empty) ? String.Empty : this.DinamicaFamiliar.Pergunta52;
                txt_52.Enabled = true;
            }
        }

        private void rbt_nao52_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao52.Checked)
            {
                txt_52.Text = Consulta.Empty;
                txt_52.Enabled = false;
            }
        }

        private void rbt_sim53_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim53.Checked)
            {
                txt_53.Text = txt_53.Text.Equals(Consulta.Empty) ? String.Empty : this.DinamicaFamiliar.Pergunta53;
                txt_53.Enabled = true;
            }
        }

        private void rbt_nao53_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao53.Checked)
            {
                txt_53.Text = Consulta.Empty;
                txt_53.Enabled = false;
            }
        }
    }
}
