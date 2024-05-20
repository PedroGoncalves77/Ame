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
    public partial class frmP32 : Form
    {
        public frmP32()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP31 p31 = new frmP31();
            this.Dispose();
            p31.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP31 p31 = new frmP31();
            this.Dispose();
            p31.ShowDialog();
        }
    }
}
