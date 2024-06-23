using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frmP6 : Form
    {
        public frmP6(FichaBebeTresMeses fichaBebeTresMeses, SaudeDaCrianca saudeDaCrianca)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.SaudeDaCrianca = saudeDaCrianca;
            txb_suplementacao.Text = this.SaudeDaCrianca.Pergunta12;
            txb_problemaRespiracao.Text = this.SaudeDaCrianca.Pergunta13;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SaudeDaCrianca.Pergunta12 = txb_suplementacao.Text;
            this.SaudeDaCrianca.Pergunta13 = txb_problemaRespiracao.Text;
            frmP5 p5 = new frmP5(this.Ficha, this.SaudeDaCrianca);
            this.Dispose();
            p5.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<SaudeDaCrianca>(context);
            var dalFicha = new DAL<FichaBebeTresMeses>(context);
            if (!Consulta.Consultar(new List<string>() { txb_problemaRespiracao.Text, txb_suplementacao.Text }))
            {
                this.SaudeDaCrianca.Pergunta12 = txb_suplementacao.Text;
                this.SaudeDaCrianca.Pergunta13 = txb_problemaRespiracao.Text;
                dal.Alterar(this.SaudeDaCrianca);
                dalFicha.Alterar(this.Ficha);
                var list = this.Ficha.NivelAtividade.ToList();
                if (!list.Any())
                this.Ficha.AdicionarNivelAtividade(new NivelDeAtividade());
                
                frmP7 p7 = new frmP7(this.Ficha,Ficha.NivelAtividade.ToList().Last());
                this.Dispose();
                p7.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void rbt_simSuplementacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim12.Checked)
            {
                txb_suplementacao.Text = txb_suplementacao.Text.Equals(Consulta.Empty) ? String.Empty : this.SaudeDaCrianca.Pergunta12;
                txb_suplementacao.Enabled = true;
            }
                
        }

        private void rbt_naoSuplementacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao12.Checked)
            {
                txb_suplementacao.Enabled = false;
                txb_suplementacao.Text = Consulta.Empty;
            }

        }

        private void rbt_simProblemaRespiracao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim13.Checked)
            {
                txb_problemaRespiracao.Text = txb_problemaRespiracao.Text.Equals(Consulta.Empty) ? String.Empty : this.SaudeDaCrianca.Pergunta13;
                txb_problemaRespiracao.Enabled = true;
            }
                
        }

        private void rbt_naoProblemaRespiracao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao13.Checked)
            {
                txb_problemaRespiracao.Enabled = false;
                txb_problemaRespiracao.Text = Consulta.Empty;
            }
        }
    }
}
