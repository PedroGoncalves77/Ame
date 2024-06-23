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
    public partial class frmP20 : Form
    {
        public frmP20(FichaBebeTresMeses fichaBebeTresMeses, DinamicaFamiliar dinamicaFamiliar)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.DinamicaFamiliar = dinamicaFamiliar;
            txt_48.Text = DinamicaFamiliar.Pergunta48;
            txt_49.Text = DinamicaFamiliar.Pergunta49;
            txt_50.Text = DinamicaFamiliar.Pergunta50;
        }

        private void lbl_45_Click(object sender, EventArgs e)
        {

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.DinamicaFamiliar.Pergunta48 = txt_48.Text;
            this.DinamicaFamiliar.Pergunta49 = txt_49.Text;
            this.DinamicaFamiliar.Pergunta50 = txt_50.Text;
            frmP19 p19 = new frmP19(this.Ficha, this.DinamicaFamiliar);
            this.Dispose();
            p19.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if (!Consulta.Consultar(new List<string>() { txt_48.Text, txt_49.Text, txt_50.Text }))
            {
                this.DinamicaFamiliar.Pergunta48 = txt_48.Text;
                this.DinamicaFamiliar.Pergunta49 = txt_49.Text;
                this.DinamicaFamiliar.Pergunta50 = txt_50.Text;
                frmP21 p21 = new frmP21(this.Ficha, this.DinamicaFamiliar);
                this.Dispose();
                p21.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void txt_50_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbt_sim48_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim48.Checked)
            {
                txt_48.Enabled = false;
                txt_48.Text = Consulta.Empty;
            }
        }

        private void rbt_nao48_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao48.Checked)
            {
                txt_48.Text = txt_48.Text.Equals(Consulta.Empty) ? String.Empty : this.DinamicaFamiliar.Pergunta48;
                txt_48.Enabled = true;
            }
        }
    }
}
