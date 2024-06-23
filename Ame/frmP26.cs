using Ame.Modelo;


namespace Ame
{
    public partial class frmP26 : Form
    {
        public frmP26(FichaBebeTresMeses fichaBebeTresMeses, ProblemaSono problemaSono)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.ProblemaSono = problemaSono;
            txt_66.Text = ProblemaSono.Pergunta66;
            txt_67.Text = ProblemaSono.Pergunta67;
            txt_68.Text = ProblemaSono.Pergunta68;
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.ProblemaSono.Pergunta66 = txt_66.Text;
            this.ProblemaSono.Pergunta67 = txt_67.Text;
            this.ProblemaSono.Pergunta68 = txt_68.Text;
            frmP25 p25 = new frmP25(this.Ficha, this.ProblemaSono);
            this.Dispose();
            p25.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if (!Consulta.Consultar(new List<string>() { txt_66.Text, txt_67.Text, txt_68.Text }))
            {
                this.ProblemaSono.Pergunta66 = txt_66.Text;
                this.ProblemaSono.Pergunta67 = txt_67.Text;
                this.ProblemaSono.Pergunta68 = txt_68.Text;
                frmP27 p27 = new frmP27(this.Ficha, this.ProblemaSono);
                this.Dispose();
                p27.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void frmP26_Load(object sender, EventArgs e)
        {

        }

        private void rbt_sim66_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim66.Checked)
            {
                txt_66.Text = txt_67.Text.Equals(Consulta.Empty) ? String.Empty : this.ProblemaSono.Pergunta66;
                txt_66.Enabled = true;
            }
        }

        private void rbt_nao66_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao66.Checked)
            {
                txt_66.Text = Consulta.Empty;
                txt_66.Enabled = false;  
            }
        }
    }
}
