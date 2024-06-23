using Ame.BD;
using Ame.Modelo;


namespace Ame
{
    public partial class frmP5 : Form
    {
        public frmP5(FichaBebeTresMeses fichaBebeTresMeses, SaudeDaCrianca saudeDaCrianca)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.SaudeDaCrianca = saudeDaCrianca;
            txb_alergia.Text = this.SaudeDaCrianca.Pergunta9;
            txb_Intestino.Text = this.SaudeDaCrianca.Pergunta10;
            txb_congestao.Text = this.SaudeDaCrianca.Pergunta11;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SaudeDaCrianca.Pergunta9 = txb_alergia.Text;
            this.SaudeDaCrianca.Pergunta10 = txb_Intestino.Text;
            this.SaudeDaCrianca.Pergunta11 = txb_congestao.Text;
            frmP4 p4 = new frmP4(this.Ficha,this.SaudeDaCrianca);
            this.Dispose();
            p4.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!Consulta.Consultar(new List<string>(){txb_congestao.Text, txb_alergia.Text, txb_Intestino.Text}))
            {
                this.SaudeDaCrianca.Pergunta9 = txb_alergia.Text;
                this.SaudeDaCrianca.Pergunta10 = txb_Intestino.Text;
                this.SaudeDaCrianca.Pergunta11 = txb_congestao.Text;
                frmP6 p6 = new frmP6(this.Ficha, this.SaudeDaCrianca);
                this.Dispose();
                p6.ShowDialog(); 
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }

        private void rbt_naoCongestao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_naoCongestao.Checked)
            {
                txb_congestao.Enabled = false;
                txb_congestao.Text = Consulta.Empty;
            }
        }

        private void lbl_4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DorOuvido_Click(object sender, EventArgs e)
        {

        }

        private void rbt_naoAlergia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_naoAlergia.Checked)
            {
                txb_alergia.Enabled = false;
                txb_alergia.Text = Consulta.Empty;
            }

        }

        private void rbt_simCongestao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_simCongestao.Checked)
            {   
                txb_congestao.Text = txb_congestao.Text.Equals(Consulta.Empty) ? String.Empty : this.SaudeDaCrianca.Pergunta11;
                txb_congestao.Enabled = true;
            }
                
        }

        private void rbt_naoIntestino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_naoIntestino.Checked)
            { txb_Intestino.Enabled = false;
                txb_Intestino.Text = Consulta.Empty;  
            }
        }

        private void rbt_simAlergia_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbt_simAlergia.Checked)
            {
                txb_alergia.Text = txb_alergia.Text.Equals(Consulta.Empty) ? String.Empty : this.SaudeDaCrianca.Pergunta9;
                txb_alergia.Enabled = true;
            }
        }   

        private void rbt_simIntestino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_simIntestino.Checked)
            {
                txb_Intestino.Text = txb_Intestino.Text.Equals(Consulta.Empty) ? String.Empty : this.SaudeDaCrianca.Pergunta10;
                txb_Intestino.Enabled = true;
            }
        }
    }
}
