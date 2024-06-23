using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frmP33 : Form
    {
        public frmP33(FichaBebeTresMeses fichaBebeTresMeses, SobreConsultoria sobreConsultoria)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.SobreConsultoria = sobreConsultoria;
            txt_92.Text = SobreConsultoria.Pergunta92;
            switch (SobreConsultoria.Pergunta90)
            {
                case "sim": rbt_sim90.Checked = true; break;
                case "nao": rbt_nao90.Checked = true; break;
            }
            switch (SobreConsultoria.Pergunta91)
            {
                case "sim": rbt_sim91.Checked = true; break;
                case "nao": rbt_nao91.Checked = true; break;
            }
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<SobreConsultoria>(context);
            this.SobreConsultoria.Pergunta92 = txt_92.Text;
            dal.Alterar(this.SobreConsultoria);
            frmP32 p32 = new frmP32(this.Ficha, this.Ficha.AmbienteSono.ToList().Last());
            this.Dispose();
            p32.ShowDialog();
        }

        private void bt_concluir_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<SobreConsultoria>(context);
            var dalFicha = new DAL<FichaBebeTresMeses>(context);
            if (!Consulta.Consultar(new List<string>() { txt_92.Text, this.SobreConsultoria.Pergunta90!, this.SobreConsultoria.Pergunta91! }))
            {
                this.SobreConsultoria.Pergunta92 = txt_92.Text;
                dal.Alterar(this.SobreConsultoria);
                dalFicha.Alterar(this.Ficha);
                this.Dispose();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");
        }

        private void rbt_sim90_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim90.Checked)
                this.SobreConsultoria.Pergunta90 = "sim";
        }

        private void rbt_nao90_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao90.Checked)
                this.SobreConsultoria.Pergunta90 = "nao";
        }

        private void rbt_sim91_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim91.Checked)
                this.SobreConsultoria.Pergunta91 = "sim";
        }

        private void rbt_nao91_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_nao91.Checked)
                this.SobreConsultoria.Pergunta91 = "nao";
        }
    }
}
