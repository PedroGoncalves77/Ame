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
    public partial class frmP22 : Form
    {
        public frmP22(FichaBebeTresMeses fichaBebeTresMeses, DinamicaFamiliar dinamicaFamiliar)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.DinamicaFamiliar = dinamicaFamiliar;
            txt_54.Text = DinamicaFamiliar.Pergunta54;
            txt_55.Text = DinamicaFamiliar.Pergunta55;
            txt_56.Text = DinamicaFamiliar.Pergunta56;
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.DinamicaFamiliar.Pergunta54 = txt_54.Text; 
            this.DinamicaFamiliar.Pergunta55 = txt_55.Text; 
            this.DinamicaFamiliar.Pergunta56 = txt_56.Text; 
            frmP21 p21 = new frmP21(this.Ficha, this.DinamicaFamiliar);
            this.Dispose();
            p21.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if (!Consulta.Consultar(new List<string>() { txt_54.Text, txt_55.Text, txt_56.Text }))
            {
                this.DinamicaFamiliar.Pergunta54 = txt_54.Text;
                this.DinamicaFamiliar.Pergunta55 = txt_55.Text;
                this.DinamicaFamiliar.Pergunta56 = txt_56.Text;
                frmP23 p23 = new frmP23(this.Ficha, this.DinamicaFamiliar);
                this.Dispose();
                p23.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void rbt_sim56_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim56.Checked)
            {
                txt_56.Text = txt_56.Text.Equals(Consulta.Empty) ? String.Empty : this.DinamicaFamiliar.Pergunta56;
                txt_56.Enabled = true;
            }
        }

        private void rbt_nao56_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao56.Checked)
            {
                txt_56.Enabled = false;
                txt_56.Text = Consulta.Empty;
            }
        }
    }
}
