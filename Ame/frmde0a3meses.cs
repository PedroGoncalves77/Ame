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
            var fichaBebeDAL = new FichaBebeTresMesesDAL(context);
            fichaBebeDAL.Adicionar(CriarFicha());



            frmP1 p1 = new frmP1();
            p1.ShowDialog();
            this.Dispose();

        }
        public FichaBebeTresMeses CriarFicha()
        {
            var fichaBebeTresMeses = new FichaBebeTresMeses(txb_nomeMae.Text, txb_profissaoMae.Text, txb_nomePai.Text, txb_profissaoPai.Text,
                txb_endereco.Text, txb_nomeCrianca.Text, int.Parse(txb_idadeCrianca.Text),
                txb_pediatra.Text);
            return fichaBebeTresMeses;
        }

        private TextBox ConsultarCampos (List<TextBox> lista) 
        {
            return lista.First(x => String.IsNullOrEmpty(x.Text))!;//teste
        }
        
    }
}
