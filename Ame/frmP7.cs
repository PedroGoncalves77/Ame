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
        public frmP7(FichaBebeTresMeses ficha, NivelDeAtividade nivelDeAtividade)
        {
            InitializeComponent();
            this.Ficha = ficha;
            this.NivelDeAtividade = nivelDeAtividade;
            txb_exposicaoLuz.Text = this.NivelDeAtividade.Pergunta14;
            txb_bebeAtivo.Text = this.NivelDeAtividade.Pergunta15;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dalFicha = new DAL<NivelDeAtividade>(context);
            NivelDeAtividade.Pergunta15 = txb_bebeAtivo.Text;
            NivelDeAtividade.Pergunta14 = txb_exposicaoLuz.Text;
            dalFicha.Alterar(this.NivelDeAtividade);
            frmP6 p6 = new frmP6(this.Ficha, this.Ficha.SaudeCrianca.ToList().Last());
            this.Dispose();
            p6.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dalFicha = new DAL<NivelDeAtividade>(context);
            if(!Consulta.Consultar(new List<string>() {txb_exposicaoLuz.Text, txb_bebeAtivo.Text }))
            {
            NivelDeAtividade.Pergunta15 = txb_bebeAtivo.Text;
            NivelDeAtividade.Pergunta14 = txb_exposicaoLuz.Text;
            dalFicha.Alterar(this.NivelDeAtividade);
            frmP8 p8 = new frmP8(this.Ficha, this.NivelDeAtividade);
            this.Dispose();
            p8.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void lbl_4_Click(object sender, EventArgs e)
        {

        }

        private void rbt_simExposicaoLuz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim14.Checked) 
            {
                txb_exposicaoLuz.Text = txb_exposicaoLuz.Text.Equals(Consulta.Empty) ? String.Empty : this.NivelDeAtividade.Pergunta14;
                txb_exposicaoLuz.Enabled = true;
            }
                
        }

        private void rbt_naoExposicaoLuz_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao14.Checked) 
            {
                txb_exposicaoLuz.Text = Consulta.Empty;
                txb_exposicaoLuz.Enabled = false;
            }
                
        }

        private void rbt_simBebeAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim15.Checked)
            {
                txb_bebeAtivo.Text = txb_bebeAtivo.Text.Equals(Consulta.Empty) ? String.Empty : this.NivelDeAtividade.Pergunta15;
                txb_bebeAtivo.Enabled = true;
            }
                
        }

        private void rbt_naoBebeAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao15.Checked)
            {
                txb_bebeAtivo.Text = Consulta.Empty;
                txb_bebeAtivo.Enabled = false;
            }
                
        }
    }
}
