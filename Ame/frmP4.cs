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
    public partial class frmP4 : Form
    {
        public frmP4()
        {
            InitializeComponent();
            if (rbt_nao8.Checked)
            {
                txt_7.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmP3 p3 = new frmP3();
            this.Dispose();
            p3.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP5 p5 = new frmP5();
            this.Dispose();
            p5.ShowDialog();

        }

        private void lbl_4_Click(object sender, EventArgs e)
        {

        }

        private void frmP4_Load(object sender, EventArgs e)
        {

        }

        private void lbl_dorOuvido_Click(object sender, EventArgs e)
        {

        }

        private void rbt_naoOuvido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao8.Checked)
                txt_8.Enabled = false;

        }

        private void rbt_simOuvido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim8.Checked)
                txt_8.Enabled = true;

        }

        private void rbt_simColica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim7.Checked)
                txt_7.Enabled = true;

        }

        private void rbt_naoColica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao7.Checked)
                txt_7.Enabled = false;

        }

        private void lbl_bebeColica_Click(object sender, EventArgs e)
        {

        }
    }
}
