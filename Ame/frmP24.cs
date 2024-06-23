using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frmP24 : Form
    {
        public frmP24(FichaBebeTresMeses fichaBebeTresMeses, ProblemaSono problemaSono)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.ProblemaSono = problemaSono;
            txt_60.Text = ProblemaSono.Pergunta60;
            txt_61.Text = ProblemaSono.Pergunta61;
            txt_62.Text = ProblemaSono.Pergunta62;
            switch (ProblemaSono.Pergunta61a)
            {
                case "sim": rbt_sim61b.Checked = true; break;
                case "nao": rbt_nao61b.Checked = true; break;
            }
        }

        private void frmP24_Load(object sender, EventArgs e)
        {

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<ProblemaSono>(context);
            this.ProblemaSono.Pergunta60 = txt_60.Text;
            this.ProblemaSono.Pergunta61 = txt_61.Text;
            this.ProblemaSono.Pergunta62 = txt_62.Text;
            dal.Alterar(this.ProblemaSono);
            frmP23 p23 = new frmP23(this.Ficha, this.Ficha.DinamicaFamiliar.ToList().Last());
            this.Dispose();
            p23.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if (!Consulta.Consultar(new List<string>() { txt_60.Text, txt_61.Text, txt_62.Text }))
            {
                this.ProblemaSono.Pergunta60 = txt_60.Text;
                this.ProblemaSono.Pergunta61 = txt_61.Text;
                this.ProblemaSono.Pergunta62 = txt_62.Text;
                frmP25 p25 = new frmP25(this.Ficha, this.ProblemaSono);
                this.Dispose();
                p25.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void rbt_sim61_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim61.Checked)
            {
                txt_61.Text = txt_61.Text.Equals(Consulta.Empty) ? String.Empty : this.ProblemaSono.Pergunta61;
                txt_61.Enabled = true;
            }
        }

        private void rbt_nao61_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao61.Checked)
            {
                txt_61.Text = Consulta.Empty;
                txt_61.Enabled = false;
            }
        }

        private void rbt_sim61b_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim61b.Checked)
                this.ProblemaSono.Pergunta61a = "sim";
        }

        private void rbt_nao61b_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_nao61b.Checked)
                this.ProblemaSono.Pergunta61a = "nao";
        }
    }
}
