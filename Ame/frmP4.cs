using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frmP4 : Form
    {
        public frmP4(FichaBebeTresMeses fichaBebeTresMeses, SaudeDaCrianca saudeDaCrianca)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.SaudeDaCrianca = saudeDaCrianca;
            txt_7.Text = SaudeDaCrianca.Pergunta7;
            txt_8.Text = SaudeDaCrianca.Pergunta8;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SaudeDaCrianca.Pergunta7 = txt_7.Text;
            this.SaudeDaCrianca.Pergunta8 = txt_8.Text;
            frmP3 p3 = new frmP3(this.Ficha, this.SaudeDaCrianca);
            this.Dispose();
            p3.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!Consulta.Consultar(new List<string>() { txt_7.Text, txt_8.Text }))
            {
                this.SaudeDaCrianca.Pergunta7 = txt_7.Text;
                this.SaudeDaCrianca.Pergunta8 = txt_8.Text;
                frmP5 p5 = new frmP5(this.Ficha, this.SaudeDaCrianca);
                this.Dispose();
                p5.ShowDialog();

            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void lbl_4_Click(object sender, EventArgs e)
        {

        }

        private void frmP4_Load(object sender, EventArgs e)
        {

        }

        private void lbl_dorOuvido_Click(object sender, EventArgs e)
        {

        }

        private void rbt_naoOuvido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao8.Checked)
            {
                txt_8.Enabled = false;
                txt_8.Text = Consulta.Empty;
            }

        }

        private void rbt_simOuvido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim8.Checked)
            {
                txt_8.Text = txt_8.Text.Equals(Consulta.Empty) ? String.Empty : this.SaudeDaCrianca.Pergunta8;
                txt_8.Enabled = true;
            }
        }


        private void rbt_simColica_CheckedChanged(object sender, EventArgs e)
        {

            if (rbt_sim7.Checked)
            {
                txt_7.Text = txt_7.Text.Equals(Consulta.Empty) ? String.Empty : this.SaudeDaCrianca.Pergunta7;
                txt_7.Enabled = true;
            }
        }

        private void rbt_naoColica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao7.Checked)
            {
                txt_7.Enabled = false;
                txt_7.Text = Consulta.Empty;
            }
        }

        private void lbl_bebeColica_Click(object sender, EventArgs e)
        {

        }
    }
}
