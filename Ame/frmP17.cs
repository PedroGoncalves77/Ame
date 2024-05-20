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
    public partial class frmP17 : Form
    {
        public frmP17()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP16 p16 = new frmP16();
            this.Dispose();
            p16.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP18 p18 = new frmP18();
            this.Dispose();
            p18.ShowDialog();
        }
    }
}
