using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frmP3 : Form
    {
        public frmP3(FichaBebeTresMeses fichaBebeTresMeses, SaudeDaCrianca saudeDaCrianca)
        {
            InitializeComponent();
            this.SaudeCrianca = saudeDaCrianca;
            this.Ficha = fichaBebeTresMeses;
            txt_5.Text = this.SaudeCrianca.Pergunta5;
            txt_6.Text = this.SaudeCrianca.Pergunta6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SaudeCrianca.Pergunta5 = txt_5.Text;
            this.SaudeCrianca.Pergunta6 = txt_6.Text;
            frmP2 p2 = new frmP2(this.Ficha, this.SaudeCrianca);
            this.Dispose();
            p2.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!Consulta.Consultar(new List<string>() { txt_5.Text, txt_6.Text }))
            {
                this.SaudeCrianca.Pergunta5 = txt_5.Text;
                this.SaudeCrianca.Pergunta6 = txt_6.Text;
                frmP4 p4 = new frmP4(this.Ficha,this.SaudeCrianca);
                this.Dispose();
                p4.ShowDialog();

            }else
    MessageBox.Show("Preencha todos os campos", "Aviso!");

        }

        private void lbl_3_Click(object sender, EventArgs e)
        {

        }
    }
}
