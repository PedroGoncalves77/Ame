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
    public partial class frmP13 : Form
    {
        public frmP13(FichaBebeTresMeses fichaBebeTresMeses, SobrePais sobrePais)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.SobrePais = sobrePais;
            txtBox3.Text = SobrePais.Pergunta34;
            txtBox4.Text = SobrePais.Pergunta35;
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<SobrePais>(context);
            this.SobrePais.Pergunta34 = txtBox3.Text;
            this.SobrePais.Pergunta35 = txtBox4.Text;
            dal.Alterar(this.SobrePais);
            frm12 p12 = new frm12(this.Ficha, this.Ficha.TemperamentoCrianca.ToList().Last());
            this.Dispose();
            p12.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            var context = new BD_Context();
            var dal = new DAL<SobrePais>(context);
            if (!Consulta.Consultar(new List<string>() {txtBox3.Text, txtBox4.Text }))
            {
                this.SobrePais.Pergunta34 = txtBox3.Text;
                this.SobrePais.Pergunta35 = txtBox4.Text;
                dal.Alterar(this.SobrePais);
                frmP14 p14 = new frmP14(this.Ficha,this.SobrePais);
                this.Dispose();
                p14.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");
            
        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
