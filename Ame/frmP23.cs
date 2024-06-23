using Ame.BD;
using Ame.Modelo;

namespace Ame
{
    public partial class frmP23 : Form
    {
        public frmP23(FichaBebeTresMeses fichaBebeTresMeses, DinamicaFamiliar dinamicaFamiliar)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.DinamicaFamiliar = dinamicaFamiliar;
            txt_57.Text = DinamicaFamiliar.Pergunta57;
            txt_58.Text = DinamicaFamiliar.Pergunta58;
            txt_59.Text = DinamicaFamiliar.Pergunta59;
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.DinamicaFamiliar.Pergunta57 = txt_57.Text;
            this.DinamicaFamiliar.Pergunta58 = txt_58.Text;
            this.DinamicaFamiliar.Pergunta59 = txt_59.Text;
            frmP22 p22 = new frmP22(this.Ficha, this.DinamicaFamiliar);
            this.Dispose();
            p22.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<DinamicaFamiliar>(context);
            var dalFicha = new DAL<FichaBebeTresMeses>(context);
            if (!Consulta.Consultar(new List<string>() { txt_57.Text, txt_58.Text, txt_59.Text }))
            {
                this.DinamicaFamiliar.Pergunta57 = txt_57.Text;
                this.DinamicaFamiliar.Pergunta58 = txt_58.Text;
                this.DinamicaFamiliar.Pergunta59 = txt_59.Text;
                dal.Alterar(this.DinamicaFamiliar);
                dalFicha.Alterar(this.Ficha);
                var list = this.Ficha.ProblemaSono.ToList();
                if (!list.Any())
                    this.Ficha.AdicionarProblemaSono(new ProblemaSono());

                frmP24 p24 = new frmP24(this.Ficha, this.Ficha.ProblemaSono.ToList().Last());
                this.Dispose();
                p24.ShowDialog();

            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }
    }
}
