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
    public partial class frmP30 : Form
    {
        public frmP30()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP29 p29 = new frmP29();
            this.Dispose();
            p29.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP31 p31 = new frmP31();
            this.Dispose();
            p31.ShowDialog();
        }

        private void rbt_sim81_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim81.Checked)
                txt_81.Enabled = true;
        }

        private void rbt_nao81_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao81.Checked) //checked vai verificar se algo foi setado
                txt_81.Enabled = false; //enabled vai habilitar para iteração
        }
    }
}
