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
    public partial class cb : Form
    {
        
        public cb()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("Nome deve conter pelo menos 4 caracteres");
                txtNome.Focus();
                return;
            }

            try
            {
                int cpf = Convert.ToInt32(mbCpf.Text.Replace(".", "").Replace("-", ""));
            }
            catch
            {
                MessageBox.Show("CPF deve conter somente números");
                mbCpf.Focus();
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

            if (cbSexo.Text.Length < 0)
            {
                MessageBox.Show("Selecione o SEXO");
                cbSexo.DroppedDown = true;
                return;
            }

            if (cbEstado.Text.Length < 0)
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
                int cep = Convert.ToInt32(mbCep.Text);
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


        }
    }
}
