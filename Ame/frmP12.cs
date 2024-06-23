using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frm12 : Form
    {
        public frm12(FichaBebeTresMeses fichaBebeTresMeses, TemperamentoCrianca temperamentoCrianca)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.TemperamentoCrianca = temperamentoCrianca;
            txt_31.Text = TemperamentoCrianca.Pergunta31;
            txt_32.Text = TemperamentoCrianca.Pergunta32;
            txt_33.Text = TemperamentoCrianca.Pergunta33;
        }
        private void bt_anterior_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<TemperamentoCrianca>(context);
            this.TemperamentoCrianca.Pergunta31 = txt_31.Text;
            this.TemperamentoCrianca.Pergunta32 = txt_32.Text;
            this.TemperamentoCrianca.Pergunta33 = txt_33.Text;
            dal.Alterar(this.TemperamentoCrianca);
            frmP11 p11 = new frmP11(this.Ficha, this.Ficha.AlimentacaoCrianca.ToList().Last());
            this.Dispose();
            p11.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<TemperamentoCrianca>(context);
            var dalFicha = new DAL<FichaBebeTresMeses>(context);
            if (!Consulta.Consultar(new List<string>() { txt_31.Text, txt_32.Text, txt_33.Text }))
            {
                this.TemperamentoCrianca.Pergunta31 = txt_31.Text;
                this.TemperamentoCrianca.Pergunta32 = txt_32.Text;
                this.TemperamentoCrianca.Pergunta33 = txt_33.Text;
                dal.Alterar(this.TemperamentoCrianca);
                dalFicha.Alterar(this.Ficha);
                var list  = this.Ficha.SobrePais.ToList();
                if (!list.Any())
                    this.Ficha.AdicionarSobrePais(new SobrePais());

                frmP13 p13 = new frmP13(this.Ficha, Ficha.SobrePais.ToList().Last());
                this.Dispose();
                p13.ShowDialog();

            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");
        }

        private void rbt_sim32_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim32.Checked)
            {
                txt_32.Text = txt_32.Text.Equals(Consulta.Empty) ? String.Empty : this.TemperamentoCrianca.Pergunta32;
                txt_32.Enabled = true; 
            }
        }

        private void rbt_sim33_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim33.Checked)
         { 
           txt_33.Enabled = true; 
           txt_33.Text = txt_33.Text.Equals(Consulta.Empty) ? String.Empty : this.TemperamentoCrianca.Pergunta33;
         }
        }

        private void rbt_naoChoro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao32.Checked)
            {
                txt_32.Enabled = false;
                txt_32.Text = Consulta.Empty;
            }
        }

        private void rbt_naoAgitado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao33.Checked)
            {
                txt_33.Enabled = false;
                txt_33.Text = Consulta.Empty;
            }
        }
    }
}
