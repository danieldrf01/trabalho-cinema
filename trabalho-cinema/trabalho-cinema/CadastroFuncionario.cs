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
    {  private int posicao = -1;
     
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
        public CadastroFuncionario(funcionario funcinario,int posicao)
        { 
            txtNomeCompleto.Text = funcinario.NomeCompleto;
            cbNacionalidade.SelectedItem = funcinario.Nacionalidade;
            mtbNumeroCelular.Text = funcinario.NumeroDeCelular;
            txtEndereso.Text = funcinario.Endereso;
            txtEmail.Text = funcinario.Email;
            mbRG.Text = funcinario.RG;
            mbCPF.Text = funcinario.cpf;
            txtIdade.Text =  Convert.ToString(funcinario.idade);
            cbsexo.SelectedItem = funcinario.sexo;
            txtEstadoCivil.Text = funcinario.esteadocivil;
            txtEndereso.Text = funcinario.Endereso;
            lbCargo.Text = funcinario.cargo;
            lbDataDeNacimento.Text = Convert.ToString(funcinario.DataNacimento);
           



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
            if (mtbNumeroCelular.Text.Length < 0)
            {
                MessageBox.Show("Numero celular  deve ser Preemchido");
                mtbNumeroCelular.Focus();
                return;


                if (txtEndereso.Text.Length == 0)
                {
                    MessageBox.Show("Numero fixo deve ser preenchido");
                    txtEndereso.Focus();
                    return;
                }
                if (txtEmail.Text.Length < 4)
                {
                    MessageBox.Show("E-mail deve conter nominimo 3 carateres");
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
                if (txtEndereso.Text.Length == 0)
                {
                    MessageBox.Show("Estado civil deve ser preenchido");
                    txtEndereso.Focus();
                    return;
                }
                if (lbCargo.Text.Length > 0)
                {
                    MessageBox.Show("Cargo deve ser preenchido");
                    lbCargo.Focus();
                    return;
                }
                if (lbDataDeNacimento.Text.Length == 0)
                {
                    MessageBox.Show("Data de nacimento deve ser preenxido");
                    lbDataDeNacimento.Focus();
                    return;
                }
                try
                {
                    double Data = Convert.ToDouble(lbDataDeNacimento.Text);
                }
                catch
                {
                    MessageBox.Show("Data de nacimento deve conter numeros inteiros");
                    lbDataDeNacimento.Focus();
                    return;
                }
                funcionario Funcionarios=new funcionario()
                {
                    NomeCompleto=txtNomeCompleto.Text,
                    Nacionalidade=cbNacionalidade.SelectedItem.ToString(),
                    NumeroDeCelular= mtbNumeroCelular.Text.ToString(),
                    Endereso=txtEndereso.Text.ToString( ),
                    Email=  txtEndereso.Text  ,
                    RG=mbRG.Text.ToString(),
                    cpf=   mbCPF.Text .ToString(),
                     idade=Convert.ToInt32(txtIdade.Text),
                     sexo=cbsexo.SelectedItem.ToString(),
                     esteadocivil=txtEstadoCivil.Text,
                  
                     cargo=txtCargo.Text,
                     DataNacimento=Convert.ToInt32(txtCargo.Text),


                };
                if (posicao == 0)
            {
                Program.pessoal[posicao] = Funcionarios;
                MessageBox.Show("Cadastro alterado com sucesso");
            }
            else 
            {
                Program.pessoal.Add(Funcionarios);
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            

                LimparCampos();
            }
            
                
        private void LimparCampos()
        {
            txtNomeCompleto.Text="";
            txtCurso.Text="";
            cbNacionalidade.SelectedIndex = -1;
            maskedDataDeNacimento.Text="";
            mtbNumeroCelular.Text="";
            mtbNumeroFixo.Text="";
            txtEndereso.Text="";
            txtEmail.Text="";
            mbRG.Text="";
            mbCPF.Text="";
            txtIdade.Text="";
            cbsexo.Text="";
            txtEstadoCivil.Text="";
            txtCargo.Text="";
        }

        }



        private void button1_Click(object sender, EventArgs e)
        {
             Dispose();
        }
}







           



        



    


