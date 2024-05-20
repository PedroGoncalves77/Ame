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
    public partial class frmP11 : Form
    {
        public frmP11()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP10 p10 = new frmP10();
            this.Dispose();
            p10.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frm12 p12 = new frm12();
            this.Dispose();
            p12.ShowDialog();
        }

        private void frmP11_Load(object sender, EventArgs e)
        {
            
        }
    }
}
