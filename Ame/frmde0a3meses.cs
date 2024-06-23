using Ame.BD;
using Ame.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ame
{
    public partial class frmde0a3meses : Form
    {
        public frmde0a3meses()
        {
            InitializeComponent();
        }



        private void bt_iniciarForm_Click(object sender, EventArgs e)
        {

            using BD_Context context = new BD_Context();
            var dalFicha = new DAL<FichaBebeTresMeses>(context);
            var dalSaude = new DAL<SaudeDaCrianca>(context);
            var saude = new SaudeDaCrianca();
           

            List<String> listaTxb = new List<String>() {txb_endereco.Text, txb_idadeCrianca.Text, txb_nomeMae.Text, txb_nomePai.Text,
                txb_pediatra.Text, txb_profissaoPai.Text, txb_profissaoMae.Text, this.mtc_Data.SelectionRange.Start.ToString(),
                this.mtc_Nascimento.SelectionRange.Start.ToString() };
            if (!Consulta.Consultar(listaTxb))
            {
                var ficha = CriarFicha();
                dalFicha.Adicionar(ficha);
                dalSaude.Adicionar(saude);
                ficha.AdicionarSaude(saude);
                frmP1 p1 = new frmP1(ficha, saude);
                p1.ShowDialog();
                this.Dispose();
            }
            else
                MessageBox.Show("Preencha todos os campos", "Aviso!");


        }
        public FichaBebeTresMeses CriarFicha()
        {
            DateTime data = this.mtc_Data.SelectionRange.Start;
            DateTime nascimeno = this.mtc_Nascimento.SelectionRange.Start;
            Double.TryParse(txb_idadeCrianca.Text.Replace('.', ','), out double idade);
            var fichaBebeTresMeses = new FichaBebeTresMeses(txb_nomeMae.Text, txb_profissaoMae.Text, txb_nomePai.Text, txb_profissaoPai.Text,
                txb_endereco.Text, txb_nomeCrianca.Text, idade,
                txb_pediatra.Text)
            { Data = data, Data_Nascimento = nascimeno };
            return fichaBebeTresMeses;
        }

        private void mtc_Nascimento_DateChanged(object sender, DateRangeEventArgs e)
        {
            bt_iniciarForm.Enabled = true;
        }
    }
}
