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
    public partial class frmP10 : Form
    {
        public frmP10(FichaBebeTresMeses fichaBebeTresMeses, AlimentacaoCrianca alimentacaoCrianca)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.AlimentacaoCrianca = alimentacaoCrianca;
            txt_22.Text = AlimentacaoCrianca.Pergunta22;
            txt_24.Text = AlimentacaoCrianca.Pergunta24;
            txt_25.Text = AlimentacaoCrianca.Pergunta25;
            switch (AlimentacaoCrianca.Pergunta23)
            {
                case "sim": rbt_sim23.Checked = true; break;
                case "nao": rbt_nao23.Checked = true; break;
            }
        }

        private void frmP10_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.AlimentacaoCrianca.Pergunta22 = txt_22.Text;
            this.AlimentacaoCrianca.Pergunta24 = txt_24.Text;
            this.AlimentacaoCrianca.Pergunta25 = txt_25.Text;
            frmP9 p9 = new frmP9(this.Ficha, this.Ficha.NivelAtividade.ToList().Last());
            this.Dispose();
            p9.ShowDialog();

        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<AlimentacaoCrianca>(context);
            if (!Consulta.Consultar(new List<string>() { txt_22.Text, txt_24.Text, txt_25.Text, this.AlimentacaoCrianca.Pergunta23! }))
            {
                this.AlimentacaoCrianca.Pergunta22 = txt_22.Text;
                this.AlimentacaoCrianca.Pergunta24 = txt_24.Text;
                this.AlimentacaoCrianca.Pergunta25 = txt_25.Text;
                dal.Alterar(this.AlimentacaoCrianca);
                frmP11 p11 = new frmP11(this.Ficha, this.AlimentacaoCrianca);
                this.Dispose();
                p11.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");
        }

        private void rbt_sim22_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim22.Checked)
            {
                txt_22.Text = txt_22.Text.Equals(Consulta.Empty) ? String.Empty : this.AlimentacaoCrianca.Pergunta22;
                txt_22.Enabled = true;
            }
        }

        private void rbt_nao22_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao22.Checked)
            {
                txt_22.Enabled = false;
                txt_22.Text = Consulta.Empty;
            }
        }

        private void rbt_sim24_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim24.Checked)
            {
                txt_24.Text = txt_24.Text.Equals(Consulta.Empty) ? String.Empty : this.AlimentacaoCrianca.Pergunta24;
                txt_24.Enabled = true;
            }
               
        }

        private void rbt_nao24_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao24.Checked)
            {
                txt_24.Enabled = false;
                txt_24.Text = Consulta.Empty;
            }
                
        }

        private void rbt_sim25_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim25.Checked)
            { 
                txt_25.Text = txt_25.Text.Equals(Consulta.Empty) ? String.Empty : this.AlimentacaoCrianca.Pergunta25;
                txt_25.Enabled = true;}
        }

        private void rbt_nao25_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao25.Checked)
            {
                txt_25.Enabled = false;
                txt_25.Text = Consulta.Empty;   
            }
                
        }

        private void rbt_sim23_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim23.Checked)
                this.AlimentacaoCrianca.Pergunta23 = "sim";
        }

        private void rbt_nao23_CheckedChanged(object sender, EventArgs e)
        {

            if (rbt_nao23.Checked)
                this.AlimentacaoCrianca.Pergunta23 = "nao";
        }
    }
}
