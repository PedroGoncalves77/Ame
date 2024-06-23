using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frmP11 : Form
    {
        public frmP11(FichaBebeTresMeses ficha, AlimentacaoCrianca alimentacao)
        {
            InitializeComponent();
            this.Ficha = ficha;
            this.AlimentacaoCrianca = alimentacao;
            txt_30.Text = AlimentacaoCrianca.Pergunta30;
            switch (AlimentacaoCrianca.Pergunta26)
            {
                case "sim": rbt_sim26.Checked = true; break;
                case "nao": rbt_nao26.Checked = true; break;
            }
            switch (AlimentacaoCrianca.Pergunta27)
            {
                case "1": rbt_um27.Checked = true; break;
                case "2": rbt_dois27.Checked = true; break;
            }
            switch (AlimentacaoCrianca.Pergunta28)
            {
                case "sim": rbt_sim28.Checked = true; break;
                case "nao": rbt_nao28.Checked = true; break;
            }
            switch (AlimentacaoCrianca.Pergunta29)
            {
                case "sim": rbt_sim29.Checked = true; break;
                case "nao": rbt_nao29.Checked = true; break;
            }
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.AlimentacaoCrianca.Pergunta30 = txt_30.Text;
            frmP10 p10 = new frmP10(this.Ficha, this.AlimentacaoCrianca);
            this.Dispose();
            p10.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<FichaBebeTresMeses>(context);
            var dalAlimentacao = new DAL<AlimentacaoCrianca>(context);
            if (!Consulta.Consultar(new List<string>() { txt_30.Text, AlimentacaoCrianca.Pergunta26!, AlimentacaoCrianca.Pergunta27!, AlimentacaoCrianca.Pergunta28!, AlimentacaoCrianca.Pergunta29! }))
            {
                this.AlimentacaoCrianca.Pergunta30 = txt_30.Text;
                dalAlimentacao.Alterar(this.AlimentacaoCrianca);
                dal.Alterar(this.Ficha);
                var list = this.Ficha.TemperamentoCrianca.ToList();
                if (!list.Any())
                    this.Ficha.AdicionarTemperamentoCrianaca(new TemperamentoCrianca());

                frm12 p12 = new frm12(this.Ficha, Ficha.TemperamentoCrianca.ToList().Last());
                this.Dispose();
                p12.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");
        }

        private void frmP11_Load(object sender, EventArgs e)
        {

        }

        private void rbt_sim26_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim26.Checked)
                this.AlimentacaoCrianca.Pergunta26 = "sim";
        }

        private void rbt_um27_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_um27.Checked)
                this.AlimentacaoCrianca.Pergunta27 = "1";
        }

        private void rbt_nao26_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao26.Checked)
                this.AlimentacaoCrianca.Pergunta26 = "nao";
        }

        private void rbt_nao28_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao28.Checked)
                this.AlimentacaoCrianca.Pergunta28 = "nao";
        }

        private void rbt_dois27_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_dois27.Checked)
                this.AlimentacaoCrianca.Pergunta27 = "2";
        }

        private void rbt_sim28_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim28.Checked)
                this.AlimentacaoCrianca.Pergunta28 = "sim";
        }

        private void rbt_sim29_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim29.Checked)
                this.AlimentacaoCrianca.Pergunta29 = "sim";
        }

        private void rbt_nao29_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao29.Checked)
                this.AlimentacaoCrianca.Pergunta29 = "nao";
        }
    }
}
