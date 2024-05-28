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
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void cmbTamanhoTaco_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grpOpcionais_Enter(object sender, EventArgs e)
        {
            cmbTamanhoPedido.SelectedIndex = -1;
            txtValorPedido.Clear();
            txtValorOpcionais.Clear();
            chkQueijoDerretido.Checked = false;
            chkPimenta.Checked = false;
            chkNachos.Checked = false;
            chkGuacamole.Checked = false;
        }

        private void chkChile_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            {
                cmbTamanhoPedido.Items.Add("Burrito de Carne - R$27,00");
                cmbTamanhoPedido.Items.Add("Taco de Carne - 19 reais");
                cmbTamanhoPedido.Items.Add("Combo de Tortillas - 21 reais");
                cmbTamanhoPedido.Items.Add("Polvoron - 8 reais");
                cmbTamanhoPedido.Items.Add("Enchiladas - 17 reais");
                cmbTamanhoPedido.Items.Add("Quesadillas - 10 reais");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorPedido = 0, valorOpcao = 0, valorTotal = 0;

            if (cmbTamanhoPedido.SelectedIndex == 1)
            {
                valorPedido = 27;
            }
            else if (cmbTamanhoPedido.SelectedIndex == 2)
            {
                valorPedido = 19;
            }
            else if (cmbTamanhoPedido.SelectedIndex == 3)
            {
                valorPedido = 21;
            } 
            else if (cmbTamanhoPedido.SelectedIndex == 4){
                valorPedido = 8;
            } 
            else if (cmbTamanhoPedido.SelectedIndex == 5)
            {
                valorPedido = 17;
            }
            else if (cmbTamanhoPedido.SelectedIndex == 6)
            {
                valorPedido = 10;
            }

            if (chkQueijoDerretido.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if (chkPimenta.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if (chkNachos.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if (chkGuacamole.Checked == true)
            {
                valorOpcao = valorOpcao + 6;

            }
            
            else
            {
                //MessageBox.Show("Calculo");
            }
            valorTotal = valorPedido + valorOpcao;


            //Concatenação do preço com o BRL
            txtValorPedido.Text = Convert.ToString(valorPedido + " reais");
            txtValorOpcionais.Text = Convert.ToString(valorOpcao + " reais");
            txtValorTotal.Text = Convert.ToString(valorTotal + " reais");
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            chkQueijoDerretido.Checked = false;
            chkPimenta.Checked = false;
            chkGuacamole.Checked = false;
            chkNachos.Checked = false;
            
            txtValorOpcionais.Clear();
            txtValorPedido.Clear();
            txtValorTotal.Clear();
            cmbTamanhoPedido.SelectedIndex = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verifica os campos 
            if (cmbTamanhoPedido.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo nome");
                cmbTamanhoPedido.Focus();
            }
        }
    }
}
