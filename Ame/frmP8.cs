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
    public partial class frmP8 : Form
    {
        public frmP8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmP7 p7 = new frmP7();
            this.Dispose();
            p7.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP9 p9 = new frmP9();
            this.Dispose();
            p9.ShowDialog();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbt_simAssisteTela_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_sim17.Checked)
            {
                txt_19.Enabled = true;
                txt_18.Enabled = true;
            }
        }

        private void rbt_naoAssisteTela_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_nao17.Checked)
            {
                txt_18.Enabled = false;
                txt_19.Enabled = false;
            }
        }
    }
}
