using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArribaSystem
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void pgrSplash_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pgrSplash.Value < 100)
            {
                pgrSplash.Value = pgrSplash.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;

                Menu menu = new Menu();
                menu.ShowDialog();
            }
        }
    }
}
