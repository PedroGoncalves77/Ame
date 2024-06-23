using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frmP32 : Form
    {
        public frmP32(FichaBebeTresMeses fichaBebeTresMeses, AmbienteSono ambienteSono)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.AmbienteSono = ambienteSono;
            txt_89a.Text = AmbienteSono.Pergunta89a;
            txt_89b.Text = AmbienteSono.Pergunta89b;
            switch (AmbienteSono.Pergunta87)
            {
                case "sim": rbt_sim87.Checked = true; break;
                case "nao": rbt_nao87.Checked = true; break;
            }
            switch (AmbienteSono.Pergunta88)
            {
                case "sim": rbt_sim88.Checked = true; break;
                case "nao": rbt_nao88.Checked = true; break;
            }
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.AmbienteSono.Pergunta89a = txt_89a.Text;
            this.AmbienteSono.Pergunta89b = txt_89b.Text;
            frmP31 p31 = new frmP31(this.Ficha, this.AmbienteSono);
            this.Dispose();
            p31.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<AmbienteSono>(context);
            var dalFicha = new DAL<FichaBebeTresMeses>(context);
            if (!Consulta.Consultar(new List<string>() {txt_89a.Text, txt_89b.Text, this.AmbienteSono.Pergunta87!, this.AmbienteSono.Pergunta88! }))
            {
                this.AmbienteSono.Pergunta89a = txt_89a.Text;
                this.AmbienteSono.Pergunta89b = txt_89b.Text;
                dal.Alterar(this.AmbienteSono);
                dalFicha.Alterar(this.Ficha);
                var list = this.Ficha.SobreConsultoria.ToList();
                if (!list.Any())
                    this.Ficha.AdicionarSobreConsultoria(new SobreConsultoria());


                frmP33 p33 = new frmP33(this.Ficha, this.Ficha.SobreConsultoria.ToList().Last());
                this.Dispose();
                p33.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void rbt_sim87_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim87.Checked)
                this.AmbienteSono.Pergunta87 = "sim";
        }

        private void rbt_nao87_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao87.Checked)
                this.AmbienteSono.Pergunta87 = "nao";
        }

        private void rbt_sim88_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim88.Checked)
                this.AmbienteSono.Pergunta88 = "sim";
        }

        private void rbt_nao88_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao88.Checked)
                this.AmbienteSono.Pergunta88 = "nao";
        }

        private void rbt_sim89_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim89.Checked)
            {
                txt_89a.Text = txt_89a.Text.Equals(Consulta.Empty) ? String.Empty : this.AmbienteSono.Pergunta89a;
                txt_89a.Enabled = true;
                txt_89b.Text = txt_89b.Text.Equals(Consulta.Empty) ? String.Empty : this.AmbienteSono.Pergunta89b;
                txt_89b.Enabled = true;
            }
        }

        private void rbt_nao89_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao89.Checked)
            {
                txt_89a.Text = Consulta.Empty;
                txt_89b.Text = Consulta.Empty;
                txt_89a.Enabled = false;
                txt_89b.Enabled = false;
            }
        }
    }
}
