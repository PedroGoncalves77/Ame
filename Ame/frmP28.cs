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
    public partial class frmP28 : Form
    {
        public frmP28()
        {
            InitializeComponent();
        }

        private void bt_anterior_Click(object sender, EventArgs e)
        {
            frmP27 p27 = new frmP27();
            this.Dispose();
            p27.ShowDialog();
            
        }

        private void bt_proximo_Click(object sender, EventArgs e)
        {
            frmP29 p29 = new frmP29();            
            this.Dispose();
            p29.ShowDialog();
        }
    }
}
