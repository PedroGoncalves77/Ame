using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frmP9 : Form
    {
        public frmP9(FichaBebeTresMeses fichaBebeTresMeses, NivelDeAtividade nivelDeAtividade)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.NivelDeAtividade = nivelDeAtividade;
            txt_21.Text = NivelDeAtividade.Pergunta21;
            switch (NivelDeAtividade.Pergunta20)
            {
                case "sim": rbt_sim20.Checked = true; break;
                case "nao": rbt_nao20.Checked = true; break;
            }
        }

        private void lbl_3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.NivelDeAtividade.Pergunta21 = txt_21.Text;
            frmP8 p8 = new frmP8(this.Ficha, this.NivelDeAtividade);
            this.Dispose();
            p8.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<NivelDeAtividade>(context);
            var dalFicha =new DAL<FichaBebeTresMeses>(context);    
            if (!Consulta.Consultar(new List<string>() { txt_21.Text, this.NivelDeAtividade.Pergunta20! }))
            {
                this.NivelDeAtividade.Pergunta21 = txt_21.Text;
                dal.Alterar(this.NivelDeAtividade);
                dalFicha.Alterar(this.Ficha);
                var list = this.Ficha.AlimentacaoCrianca.ToList();
                if(!list.Any()) 
                    this.Ficha.AdicionarAlimentacaoCrianaca(new AlimentacaoCrianca());

                frmP10 p10 = new frmP10(this.Ficha, this.Ficha.AlimentacaoCrianca.ToList().Last());
                this.Dispose();
                p10.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void rbt_sim20_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim20.Checked)
                NivelDeAtividade.Pergunta20 = "sim";
        }

        private void rbt_nao20_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao20.Checked)
                NivelDeAtividade.Pergunta20 = "nao";
        }
    }
}
