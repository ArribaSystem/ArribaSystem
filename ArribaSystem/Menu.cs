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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //btnSair.FlatStyle = FlatStyle.Flat;
            //btnSair.FlatAppearance.BorderSize = 0;

            if (MessageBox.Show("Deseja mesmo Sair", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //btnCliente.FlatStyle = FlatStyle.Flat;
            //btnCliente.FlatAppearance.BorderSize = 0;

            frmCliente cliente = new frmCliente();
            cliente.Show();
            this.Hide();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            //btnPedido.FlatStyle = FlatStyle.Flat;
            //btnPedido.FlatAppearance.BorderSize = 0;

            frmPedido pedido = new frmPedido();
            pedido.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
