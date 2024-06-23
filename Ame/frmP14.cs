using Ame.BD;
using Ame.Modelo;

namespace Ame
{
    public partial class frmP14 : Form
    {
        public frmP14(FichaBebeTresMeses fichaBebeTresMeses, SobrePais sobrePais)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.SobrePais = sobrePais;
            txt_35.Text = SobrePais.Pergunta35v1;
            txt_36.Text = SobrePais.Pergunta36;
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.SobrePais.Pergunta35v1 = txt_35.Text;
            this.SobrePais.Pergunta36 = txt_36.Text;
            frmP13 p13 = new frmP13(this.Ficha, this.SobrePais);
            this.Dispose();
            p13.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            
            if (!Consulta.Consultar(new List<string>() { txt_35.Text, txt_36.Text }))
            {
                this.SobrePais.Pergunta35v1 = txt_35.Text;
                this.SobrePais.Pergunta36 = txt_36.Text;
                frmP15 p15 = new frmP15(this.Ficha, this.SobrePais);
                this.Dispose();
                p15.ShowDialog();
            }
            
        }
    }
}
