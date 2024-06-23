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
    public partial class frmP27 : Form
    {
        public frmP27(FichaBebeTresMeses fichaBebeTresMeses, ProblemaSono problemaSono)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.ProblemaSono = problemaSono;
            txt_69.Text = ProblemaSono.Pergunta69;
            txt_72.Text = ProblemaSono.Pergunta72;
            txt_73.Text = ProblemaSono.Pergunta73;
            switch (ProblemaSono.Pergunta70)
            {
                case "sim": rbt_sim70.Checked = true; break;
                case "nao": rbt_nao70.Checked = true; break;
            }
            switch (ProblemaSono.Pergunta71)
            {
                case "sim": rbt_sim71.Checked = true; break;
                case "nao": rbt_nao71.Checked = true; break;
            }
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.ProblemaSono.Pergunta69 = txt_69.Text;
            this.ProblemaSono.Pergunta72 = txt_72.Text;
            this.ProblemaSono.Pergunta73 = txt_73.Text;
            frmP26 p26 = new frmP26(this.Ficha, this.ProblemaSono);
            this.Dispose();
            p26.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<ProblemaSono>(context);
            var dalFicha = new DAL<FichaBebeTresMeses>(context);
            if (!Consulta.Consultar(new List<string>() { txt_69.Text, txt_72.Text, txt_73.Text, this.ProblemaSono.Pergunta70!, this.ProblemaSono.Pergunta71! }))
            {
                this.ProblemaSono.Pergunta69 = txt_69.Text;
                this.ProblemaSono.Pergunta72 = txt_72.Text;
                this.ProblemaSono.Pergunta73 = txt_73.Text;
                dal.Alterar(this.ProblemaSono);
                dalFicha.Alterar(this.Ficha);
                var list = this.Ficha.AmbienteSono.ToList();
                if(!list.Any())
                    this.Ficha.AdicionarAmbienteSono(new AmbienteSono());


                frmP28 p28 = new frmP28(this.Ficha, this.Ficha.AmbienteSono.ToList().Last());
                this.Dispose();
                p28.ShowDialog(); 
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");
        }

        private void rbt_sim69_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim69.Checked)
            {
                txt_69.Text = txt_69.Text.Equals(Consulta.Empty) ? String.Empty : this.ProblemaSono.Pergunta69;
                txt_69.Enabled = true;
            }
        }

        private void rbt_nao69_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao69.Checked)
            {
                txt_69.Text = Consulta.Empty;
                txt_69.Enabled = false;
            }
        }

        private void rbt_sim70_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim70.Checked)
                this.ProblemaSono.Pergunta70 = "sim";

        }

        private void rbt_nao70_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao70.Checked)
                this.ProblemaSono.Pergunta70 = "nao";
        }

        private void rbt_sim71_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim71.Checked)
                this.ProblemaSono.Pergunta71 = "sim";
        }

        private void rbt_nao71_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_nao71.Checked)
                this.ProblemaSono.Pergunta71 = "nao";
        }
    }
}
