using Ame.Modelo;


namespace Ame
{
    public partial class frmP29 : Form
    {
        public frmP29(FichaBebeTresMeses fichaBebeTresMeses, AmbienteSono ambienteSono)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.AmbienteSono = ambienteSono;
            txt_80.Text = AmbienteSono.Pergunta80;
            txt_81.Text = AmbienteSono.Pergunta81;
            switch (AmbienteSono.Pergunta82)
            {
                case "sim": rbt_sim82.Checked = true; break;
                case "nao": rbt_nao82.Checked = true; break;
            }
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.AmbienteSono.Pergunta80 = txt_80.Text;
            this.AmbienteSono.Pergunta81 = txt_81.Text;
            frmP28 p28 = new frmP28(this.Ficha, this.AmbienteSono);
            this.Dispose();
            p28.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if (!Consulta.Consultar(new List<string>() { txt_80.Text, txt_81.Text, this.AmbienteSono.Pergunta82! }))
            {
                this.AmbienteSono.Pergunta80 = txt_80.Text;
                this.AmbienteSono.Pergunta81 = txt_81.Text;
                frmP31 p31 = new frmP31(this.Ficha, this.AmbienteSono);
                this.Dispose();
                p31.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");


        }

        private void rbt_sim81_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim81.Checked)
            {
                txt_81.Text = txt_81.Text.Equals(Consulta.Empty) ? String.Empty : this.AmbienteSono.Pergunta81;
                txt_81.Enabled = true;
            }
        }

        private void rbt_nao81_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao81.Checked)
            {
                txt_81.Text = Consulta.Empty;
                txt_81.Enabled = false;
            }
        }

        private void rbt_sim82_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim82.Checked)
                this.AmbienteSono.Pergunta82 = "sim";
        }

        private void rbt_nao82_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao82.Checked)
                this.AmbienteSono.Pergunta82 = "nao";
        }
    }
}
