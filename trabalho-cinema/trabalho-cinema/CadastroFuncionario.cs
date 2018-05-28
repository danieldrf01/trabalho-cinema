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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lbNomeCompleto_Click(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text.Length < 4)
            {
                MessageBox.Show("Nome deve comter no minimo 4 carateres");
                txtNomeCompleto.Focus();
                return;
            }
            if (cbNacionalidade.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma nacionalidade");
                cbNacionalidade.DroppedDown = true;
                return;
            }
            if (maskedTextBox3.Text.Length > 0)
            {
                MessageBox.Show("Numero deve ser Premchido");
                maskedTextBox3.Focus();
                return;

            }
            try
            {
                double Numero = Convert.ToDouble(maskedTextBox3.Text);
            }
            catch
            {
                MessageBox.Show("Numero de Preenchido com Numeros Reais");
                maskedTextBox3.Focus();
                return;
            }
            if (txtEndereso.Text.Length == 0)
            {
                MessageBox.Show("Numero deve ser preenchido");
                txtEndereso.Focus();
                return;
            }
            if (txtEmail.Text.Length < 4)
            {
                MessageBox.Show("E-mail devaconter nominimo 4 carateres");
                txtEmail.Focus();
                return;

            }
            if (mbRG.Text.Length == 0)
            {
                MessageBox.Show("GR deve ser prenchiudo");
                mbRG.Focus();
                return;
            }
            if (mbCPF.Text.Length == 0)
            {
                MessageBox.Show("CPF deve ser preenchido ");
                mbCPF.Focus();
                return;

            }
            if (txtIdade.Text.Length == 0)
            {
                MessageBox.Show("idade deve ser preenchido com numero inteiros ");
                mbCPF.Focus();
                return;
            }
            if (cbsexo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um sexo ");
                cbsexo.DroppedDown = true;
                return;
            }
            if (txtEstadoCivil.Text.Length == 0)
            {
                MessageBox.Show("Estado civil deve ser preenchido com numero inteiros ");
                txtEstadoCivil.Focus();
                return;
            }
            

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
       
    }
}
