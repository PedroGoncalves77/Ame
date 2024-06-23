using Ame.Modelo;


namespace Ame
{
    public partial class frmP19 : Form
    {
        public frmP19(FichaBebeTresMeses fichaBebeTresMeses, DinamicaFamiliar dinamicaFamiliar)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.DinamicaFamiliar = dinamicaFamiliar; 
            txb_45.Text = DinamicaFamiliar.Pergunta45;
            txt_46.Text = DinamicaFamiliar.Pergunta46;
            txt_47a.Text =DinamicaFamiliar.Pergunta47;
            txt_47b.Text = DinamicaFamiliar.Pergunta47a;
            txt_47c.Text = DinamicaFamiliar.Pergunta47b;
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.DinamicaFamiliar.Pergunta45 = txb_45.Text;
            this.DinamicaFamiliar.Pergunta46 = txt_46.Text;
            this.DinamicaFamiliar.Pergunta47 = txt_47a.Text;
            this.DinamicaFamiliar.Pergunta47a = txt_47b.Text;
            this.DinamicaFamiliar.Pergunta47b = txt_47c.Text;
            frmP18 p18 = new frmP18(this.Ficha, this.DinamicaFamiliar);
            this.Dispose();
            p18.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if(!Consulta.Consultar(new List<string>() {txb_45.Text, txt_46.Text, txt_47a.Text, txt_47b.Text, txt_47c.Text}))
            {
                this.DinamicaFamiliar.Pergunta45 = txb_45.Text;
                this.DinamicaFamiliar.Pergunta46 = txt_46.Text;
                this.DinamicaFamiliar.Pergunta47 = txt_47a.Text;
                this.DinamicaFamiliar.Pergunta47a = txt_47b.Text;
                this.DinamicaFamiliar.Pergunta47b = txt_47c.Text;
                frmP20 p20 = new frmP20(this.Ficha, this.DinamicaFamiliar);
                this.Dispose();
                p20.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");
        }

        private void rbt_sim47_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim47.Checked)
           {     
                txt_47a.Text = txt_47a.Text.Equals(Consulta.Empty) ? String.Empty : this.DinamicaFamiliar.Pergunta47;
                txt_47a.Enabled = true;
                txt_47b.Text = txt_47b.Text.Equals(Consulta.Empty) ? String.Empty : this.DinamicaFamiliar.Pergunta47a;
                txt_47b.Enabled = true;
                txt_47c.Text = txt_47c.Text.Equals(Consulta.Empty) ? String.Empty : this.DinamicaFamiliar.Pergunta47b;
                txt_47c.Enabled = true;
            }
        }

        private void rbt_nao47_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao47.Checked)
            {
                txt_47a.Enabled = false;
                txt_47a.Text = Consulta.Empty;
                txt_47b.Enabled = false;
                txt_47b.Text = Consulta.Empty;
                txt_47c.Enabled = false;
                txt_47c.Text = Consulta.Empty;

            }
        }
    }
}
