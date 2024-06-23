using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frmP2 : Form
    {
        public frmP2(FichaBebeTresMeses fichaBebeTres, SaudeDaCrianca saudeDaCrianca)
        {
            InitializeComponent();
            this.SaudeCrianca = saudeDaCrianca;
            this.Ficha =fichaBebeTres;
            txt_3.Text = this.SaudeCrianca.Pergunta3;
            txt_4.Text = this.SaudeCrianca.Pergunta4;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SaudeCrianca.Pergunta3 = txt_3.Text;
            this.SaudeCrianca.Pergunta4 = txt_4.Text;
            frmP1 p1 = new frmP1(this.Ficha, this.SaudeCrianca);
            this.Dispose();
            p1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (!Consulta.Consultar(new List<string>() { txt_3.Text, txt_4.Text }))
            {   
                this.SaudeCrianca.Pergunta3 = txt_3.Text;
                this.SaudeCrianca.Pergunta4 = txt_4.Text;
                frmP3 p3 = new frmP3(this.Ficha, this.SaudeCrianca);
                this.Dispose();
                p3.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos", "Aviso!");

        }
    }
}
