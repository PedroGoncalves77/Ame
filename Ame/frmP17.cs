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
    public partial class frmP17 : Form
    {
        public frmP17(FichaBebeTresMeses fichaBebeTresMeses, SobrePais sobrePais)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.SobrePais = sobrePais;
            txt_42.Text = SobrePais.Pergunta42;
            txb_41.Text = SobrePais.Pergunta41;
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.SobrePais.Pergunta41 = txb_41.Text;
            this.SobrePais.Pergunta42 = txt_42.Text;
            frmP16 p16 = new frmP16(this.Ficha, this.SobrePais);
            this.Dispose();
            p16.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dalFicha = new DAL<FichaBebeTresMeses>(context);
            var dal = new DAL<SobrePais>(context);
            if (!Consulta.Consultar(new List<string>() { txt_42.Text, txb_41.Text }))
            {
                this.SobrePais.Pergunta41 = txb_41.Text;
                this.SobrePais.Pergunta42 = txt_42.Text;
                dal.Alterar(this.SobrePais);
                dalFicha.Alterar(this.Ficha);
                var list = this.Ficha.DinamicaFamiliar.ToList();
                if (!list.Any())
                    this.Ficha.AdicionarDinamica(new DinamicaFamiliar());

                frmP18 p18 = new frmP18(this.Ficha,this.Ficha.DinamicaFamiliar.ToList().Last());
                this.Dispose();
                p18.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }
    }
}
