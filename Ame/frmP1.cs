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
    public partial class frmP1 : Form
    {
        public frmP1(FichaBebeTresMeses ficha, SaudeDaCrianca saudeDaCrianca)
        {
            InitializeComponent();
            this.Ficha = ficha;
            this.SaudeDaCrianca = saudeDaCrianca;
            this.txt_2.Text = SaudeDaCrianca.Pergunta2;
        }

        private void frm_P1_Load(object sender, EventArgs e)
        {
            

        }

        private void txb_sobreSaude_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using BD_Context context = new BD_Context();
            var dal = new DAL<SaudeDaCrianca>(context);
            if (!(Consulta.Consultar(new List<string> { this.txt_2.Text })))
            {
                this.SaudeDaCrianca.Pergunta1 = monthCalendar1.SelectionRange.Start;
                this.SaudeDaCrianca.Pergunta2 = txt_2.Text;
                dal.Alterar(this.SaudeDaCrianca);
                frmP2 p2 = new frmP2(this.Ficha, this.SaudeDaCrianca);
                this.Dispose();
                p2.ShowDialog();
            }
            else
                MessageBox.Show("Preencha todos os campos", "Aviso!");

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           button1.Enabled = true;
        }
       
    }
}
