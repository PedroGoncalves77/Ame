using Ame.BD;
using Ame.Modelo;

namespace Ame
{
    public partial class frmP15 : Form
    {
        public frmP15(FichaBebeTresMeses fichaBebeTresMeses, SobrePais sobrePais)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.SobrePais = sobrePais;
            txt_38.Text = SobrePais.Pergunta38;
            txt_37.Text = SobrePais.Pergunta37;

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.SobrePais.Pergunta37 = txt_37.Text;
            this.SobrePais.Pergunta38 = txt_38.Text;
            frmP14 p14 = new frmP14(this.Ficha,this.SobrePais);
            this.Dispose();
            p14.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            
            if (!Consulta.Consultar(new List<string>() { txt_37.Text, txt_38.Text }))
            {
                this.SobrePais.Pergunta37 = txt_37.Text;
                this.SobrePais.Pergunta38 = txt_38.Text;
                frmP16 p16 = new frmP16(this.Ficha, this.SobrePais);
                this.Dispose();
                p16.ShowDialog();

            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }
    }
}
