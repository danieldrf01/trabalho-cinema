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
    public partial class CadastroCliente : Form
    {
        private int posicao = -1;
        
        public CadastroCliente()
        {
            InitializeComponent();
        }

        public CadastroCliente(Cliente cliente, int posicao)
        {
            InitializeComponent();
            this.posicao = posicao;

            txtNome.Text = cliente.Nome;
            mbCpf.Text = Convert.ToString(cliente.Cpf);
            cbSexo.SelectedItem = cliente.Sexo;
            cbEstado.SelectedItem = cliente.Estado;
            txtEmail.Text = cliente.Email;
            mbDataDeNascimento.Text = Convert.ToString(cliente.DataDeNascimento);
            txtCidade.Text = cliente.Cidade;
            txtEndereco.Text = cliente.Endereco;
            txtNumero.Text = Convert.ToString(cliente.Numero);
            txtComplemento.Text = cliente.Complemento;
            txtTelefone.Text = Convert.ToString(cliente.Telefone);
            txtBairro.Text = cliente.Bairro;
            mbCep.Text = Convert.ToString(cliente.Cep);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter pelo menos 4 caracteres");
                txtNome.Focus();
                return;
            }

            if (mbCpf.Text.Length < 11)
            {
                MessageBox.Show("CPF Deve conter 11 digitos");
                mbCpf.Focus();
                return;
            }

            if (txtEmail.Text.Length < 0)
            {
                MessageBox.Show("Digite o E-mail");
                txtEmail.Focus();
            }

            if (cbSexo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o SEXO");
                cbSexo.DroppedDown = true;
                return;
            }

            if (cbEstado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione O ESTADO");
                cbEstado.DroppedDown = true;
                return;
            }

            if (txtCidade.Text.Length < 0)
            {
                MessageBox.Show("Selecione a CIDADE");
                txtCidade.Focus();
                return;
            }

            if (txtEndereco.Text.Length < 0)
            {
                MessageBox.Show("Digite o ENDEREÇO");
                txtEndereco.Focus();
                return;
            }

            if (txtNumero.Text.Length < 0)
            {
                MessageBox.Show("Digite o NÚMERO");
                txtNumero.Focus();
                return;
            }

            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
            }
            catch 
            {
                MessageBox.Show("Número deve conter somente algarismos");
                return;
            }

            if (txtBairro.Text.Length < 0)
            {
                MessageBox.Show("Digite o bairro");
                txtBairro.Focus();
                return;
            }

            if (mbCep.Text.Length < 0)
            {
                MessageBox.Show("Digite o CEP");
                return;
            }

            try
            {
                string cep = (mbCep.Text.Replace("-", ""));
            
            }
            catch 
            {
                MessageBox.Show("Cep deve conter somente números");
                return;
            }

            if (txtTelefone.Text.Length < 0)
            {
                MessageBox.Show("Digite um Telefone");
                txtTelefone.Focus();
                return;
            }

            try
            {
                int telefone = Convert.ToInt32(txtTelefone.Text);
            }
            catch 
            {
                MessageBox.Show("Telefone deve conter somente números");
                return;
            }

            Cliente cliente = new Cliente() 
            {

            Nome = txtNome.Text,
            Cpf = mbCpf.Text,
            Sexo = Convert.ToString(cbSexo.SelectedItem),
            Estado = Convert.ToString(cbEstado.SelectedItem),
            Email = txtEmail.Text,
            DataDeNascimento = Convert.ToInt32(mbDataDeNascimento.Text),
            Cidade = txtCidade.Text,
            Endereco = txtEndereco.Text,
            Numero = Convert.ToInt32(txtNumero.Text),
            Complemento = txtComplemento.Text,
            Telefone = Convert.ToInt32(txtTelefone.Text),
            Bairro = txtBairro.Text,
            Cep = mbCep.Text 

            };

            if (posicao >= 0)
            {
                Program.clientes[posicao] = cliente;
                MessageBox.Show("Cadastro alterado com sucesso");
            }

            else
            {
                Program.clientes.Add(cliente);
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
            mbCpf.Text = "";
            cbSexo.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            mbDataDeNascimento.Text = "";
            mbCep.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
