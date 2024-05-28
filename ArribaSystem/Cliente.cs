using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ArribaSystem
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        // METODO HABILITAR CAMPOS
        private void habilitaCampos()
        {
            txtEmail.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            txtNome.Focus(); //DEIXA A SETINHA NO CAMPO NOME
        }
        private void desabiltaCampos()
        {
            txtEmail.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            txtPesquisar.Clear(); //LIMPA O CAMPO PESQUISAR
            txtPesquisar.Focus();
            limpaCampos(); //CHAMANDO O METODO LIMPA CAMPOS
        }

        // LIMPA CAMPOS
        private void limpaCampos()
        {
            txtEmail.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtPesquisar.Clear();
            dgvCliente.DataSource = null; //LIMPA O DATAGRIDVIEW
        }

        public void carregarImagem(PictureBox pbFotoCliente)
        {
            //vai filtrar o tipo de imagem 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imagem|*.jpg;*.doc;*.xls;*.ppt;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //vai ler o tamanho do arquivo selecionado
                FileInfo file = new FileInfo(openFileDialog1.FileName);


                //testa se tem menos de 1MB (1MB em bytes = 1048576)
                if (file.Length <= 1048576)
                    pbFotoCliente.ImageLocation = openFileDialog1.FileName;
                else
                    MessageBox.Show("Arquivo Maior que 1MB!");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregarImagem(pbFotoCliente);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void lblPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void pbFotoCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
