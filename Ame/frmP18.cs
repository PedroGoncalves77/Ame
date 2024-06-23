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
    public partial class frmP18 : Form
    {
        public frmP18(FichaBebeTresMeses fichaBebeTresMeses, DinamicaFamiliar dinamicaFamiliar)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.DinamicaFamiliar = dinamicaFamiliar;
            txb_43.Text = DinamicaFamiliar.Pergunta43;
            txt_44.Text = DinamicaFamiliar.Pergunta44;
        }

        private void frmP18_Load(object sender, EventArgs e)
        {

        }

        private void lbl_44_Click(object sender, EventArgs e)
        {

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            using var context = new BD_Context();
            var dal = new DAL<DinamicaFamiliar>(context);
            this.DinamicaFamiliar.Pergunta43 = txb_43.Text;
            this.DinamicaFamiliar.Pergunta44 = txt_44.Text;
            dal.Alterar(this.DinamicaFamiliar);
            frmP17 p17 = new frmP17(this.Ficha, this.Ficha.SobrePais.ToList().Last());
            this.Dispose();
            p17.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if (!Consulta.Consultar(new List<string>() { txb_43.Text, txt_44.Text }))
            {
                this.DinamicaFamiliar.Pergunta43 = txb_43.Text;
                this.DinamicaFamiliar.Pergunta44 = txt_44.Text;
                frmP19 p19 = new frmP19(this.Ficha, this.DinamicaFamiliar);
                this.Dispose();
                p19.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }
    }
}
