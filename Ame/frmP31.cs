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
    public partial class frmP31 : Form
    {
        public frmP31(FichaBebeTresMeses fichaBebeTresMeses, AmbienteSono ambienteSono)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.AmbienteSono = ambienteSono;
            txt_85.Text = AmbienteSono.Pergunta85;
            txt_86.Text = AmbienteSono.Pergunta86;
            switch (AmbienteSono.Pergunta83)
            {
                case "sim": rbt_sim83.Checked = true; break;
                case "nao": rbt_nao83.Checked = true; break;
            }
            switch (AmbienteSono.Pergunta84)
            {
                case "sim": rbt_sim84.Checked = true; break;
                case "nao": rbt_nao84.Checked = true; break;
            }
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.AmbienteSono.Pergunta85 = txt_85.Text;
            this.AmbienteSono.Pergunta86 = txt_86.Text;
            frmP29 p29 = new frmP29(this.Ficha, this.AmbienteSono);
            this.Dispose();
            p29.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if (Consulta.Consultar(new List<string>() { txt_85.Text, txt_86.Text, this.AmbienteSono.Pergunta83!, this.AmbienteSono.Pergunta84! }))
            {
                this.AmbienteSono.Pergunta85 = txt_85.Text;
                this.AmbienteSono.Pergunta86 = txt_86.Text;
                frmP32 p32 = new frmP32(this.Ficha, this.AmbienteSono);
                this.Dispose();
                p32.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void rbt_sim83_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim83.Checked)
                this.AmbienteSono.Pergunta83 = "sim";
        }

        private void rbt_nao83_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao83.Checked)
                this.AmbienteSono.Pergunta83 = "nao";
        }

        private void rbt_sim84_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim84.Checked)
                this.AmbienteSono.Pergunta84 = "sim";
        }

        private void rbt_nao84_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_nao84.Checked)
                this.AmbienteSono.Pergunta84 = "nao";
        }
    }
}
