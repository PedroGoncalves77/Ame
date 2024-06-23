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
    public partial class frmP25 : Form
    {
        public frmP25(FichaBebeTresMeses fichaBebeTresMeses, ProblemaSono problemaSono)
        {
            InitializeComponent();
            this.Ficha = fichaBebeTresMeses;
            this.ProblemaSono = problemaSono;
            txt_63.Text = ProblemaSono.Pergunta63;
            txt_64.Text = ProblemaSono.Pergunta64;
            txt_65.Text = ProblemaSono.Pergunta65;
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            this.ProblemaSono.Pergunta63 = txt_63.Text;
            this.ProblemaSono.Pergunta64 = txt_64.Text;
            this.ProblemaSono.Pergunta65 = txt_65.Text;
            frmP24 p24 = new frmP24(this.Ficha, this.ProblemaSono);
            this.Dispose();
            p24.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            if (!Consulta.Consultar(new List<string>() { txt_63.Text, txt_64.Text, txt_65.Text }))
            {
                this.ProblemaSono.Pergunta63 = txt_63.Text;
                this.ProblemaSono.Pergunta64 = txt_64.Text;
                this.ProblemaSono.Pergunta65 = txt_65.Text;
                frmP26 p26 = new frmP26(this.Ficha, this.ProblemaSono);
                this.Dispose();
                p26.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos!", "Aviso!");

        }
    }
}
