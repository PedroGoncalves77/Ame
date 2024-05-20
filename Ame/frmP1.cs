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
    public partial class frmP1 : Form
    {
        public frmP1()
        {
            InitializeComponent();
        }

        private void frm_P1_Load(object sender, EventArgs e)
        {

        }

        private void txb_sobreSaude_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP2 p2 = new frmP2();
            this.Dispose(); 
            p2.ShowDialog();
            
        }
    }
}
