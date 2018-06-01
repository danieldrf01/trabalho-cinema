using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_cinema
{
    public partial class CadastroFornecedor : Form
    {
        private int posicao = -1;

        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        public CadastroFornecedor(Fornecedor fornecedor, int posicao)
        {
            InitializeComponent();
            this.posicao = posicao;

            txtNome.Text = fornecedor.Nome;
            mbCnpj.Text= fornecedor.Cnpj;
            txtEmail.Text = fornecedor.Email;
            cbEstado.SelectedItem = Convert.ToString(fornecedor.Estado);
            txtCidade.Text = fornecedor.Cidade;
            txtEndereco.Text = fornecedor.Endereco;
            txtNumero.Text = fornecedor.Numero;
            txtComplemento.Text = fornecedor.Complemento;
            txtTelefone.Text = fornecedor.Telefone;
            txtBairro.Text = fornecedor.Bairro;
            mbCep.Text = fornecedor.Cep;
            rbBebida.Text = Convert.ToString(fornecedor.Bebida);
            rbAlimento.Text = Convert.ToString(fornecedor.Alimento);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter pelo menos 4 caracteres");
                txtNome.Focus();
                return;
            }

            if (mbCnpj.Text.Length < 14)
            {
                MessageBox.Show("CNPJ deve conter 14 digitos");
                mbCnpj.Focus();
                return;
            }

            if (cbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um estado");
                cbEstado.DroppedDown = true;
                return;
            }

            if (txtEmail.Text.Length < 0)
            {
                MessageBox.Show("Digite um E-mail");
                txtEmail.Focus();
                return;
            }

            if (txtCidade.Text.Length < 0)
            {
                MessageBox.Show("Digite uma Cidade");
                txtCidade.Focus();
                return;
            }

            if (txtEndereco.Text.Length < 0)
            {
                MessageBox.Show("Digite um endereço");
                txtEndereco.Focus();
                return;
            }

            if (txtTelefone.Text.Length < 0)
            {
                MessageBox.Show("Digite um telefone");
                txtTelefone.Focus();
                return;
            }

            try
            {
                int telefone = Convert.ToInt32(txtTelefone.Text);
            }
            catch
            {
                MessageBox.Show("Telefone deve conter apenas números");
                return;
            }

            if (txtBairro.Text.Length < 0)
            {
                MessageBox.Show("Digite um bairro");
                txtBairro.Focus();
                return;
            }

            if (mbCep.Text.Length < 0)
            {
                MessageBox.Show("Digite um CEP");
                mbCep.Focus();
                return;
            }

            Fornecedor fornecedor = new Fornecedor() 
            {
                Nome = txtNome.Text,
                Cnpj = mbCnpj.Text,
                Estado = Convert.ToString(cbEstado.SelectedItem),
                Email= txtEmail.Text,
                Cidade = txtCidade.Text,
                Endereco = txtEndereco.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text,
                Telefone = txtTelefone.Text,
                Bairro = txtBairro.Text,
                Cep = mbCep.Text,
                Bebida = rbBebida.Checked,
                Alimento = rbAlimento.Checked
            };

            if (posicao >= 0)
            {
                Program.fornecedores[posicao] = fornecedor;
                MessageBox.Show("Cadastro alterado com sucesso");
            }

            else
            {
                Program.fornecedores.Add(fornecedor);
                MessageBox.Show("Cadastro realizado com sucesso");
            }
                LimparCampos();
                 
            }
    
         private void LimparCampos()
         {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtTelefone.Text = "";
            txtBairro.Text = "";
            mbCnpj.Text = "";
            mbCep.Text = "";
            cbEstado.SelectedIndex = -1;
            rbBebida.Checked = true;
            rbAlimento.Checked = true;
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
    }
}
