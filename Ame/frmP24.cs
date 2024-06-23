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
    public partial class frmP24 : Form
    {
        public frmP24()
        {
            InitializeComponent();
        }

        private void frmP24_Load(object sender, EventArgs e)
        {

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            //frmP23 p23 = new frmP23();
            this.Dispose();
            //p23.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP25 p25 = new frmP25();
            this.Dispose();
            p25.ShowDialog();
        }
    }
}
