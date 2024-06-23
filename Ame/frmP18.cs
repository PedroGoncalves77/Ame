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
    public partial class frmP18 : Form
    {
        public frmP18()
        {
            InitializeComponent();
        }

        private void frmP18_Load(object sender, EventArgs e)
        {

        }

        private void lbl_44_Click(object sender, EventArgs e)
        {

        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            //frmP17 p17 = new frmP17();
            this.Dispose();
            //p17.ShowDialog();
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP19 p19 = new frmP19();
            this.Dispose();
            p19.ShowDialog();
        }
    }
}
