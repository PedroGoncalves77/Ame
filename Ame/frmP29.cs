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
    public partial class frmP29 : Form
    {
        public frmP29()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP28 p28 = new frmP28();
            this.Dispose();
            p28.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP30 p30 = new frmP30();
            this.Dispose();
            p30.ShowDialog();
        }
    }
}
