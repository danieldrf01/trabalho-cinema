using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_CINEMA
{
    public partial class FuncionarioForm : Form
    {
        public FuncionarioForm()
        {
            InitializeComponent();
            FuncionarioObserver.addGrid(dataGridViewFuncionario);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var dataAtual = DateTime.Now;

            StringBuilder massage = new StringBuilder();

            if (txtNome.Text.Trim().Length < 4)
            {
                massage.AppendLine("Nome deve conter no mínimo 4 caracteres \n\r");
                txtNome.Focus();

            }
            if (txtCurso.Text.Length == 0)
            {
                massage.AppendLine("Curso deve conter no mínimo 4 caracteres \n\r");
                txtCurso.Focus();


            }
            if (txtFuncionarioNacionalidade.Text.Trim().Length == 0)
            {
                massage.AppendLine("Dijite sua nacionalidade \n\r");


            }
            if (mtbNumeroCelular.Text.Length == 0)
            {
                massage.AppendLine("Numero do celular deve ser preenchido \n\r");
                mtbNumeroCelular.Focus();

            }

            if (txtEmail.Text.Length == 0)
            {
                massage.AppendLine("Valor deve ser preenchido \n\r");
                txtEmail.Focus();

            }
            if (mtbRG.Text.Length == 0)
            {
                massage.AppendLine("rg deve ser preenchido \n\r");
                mtbRG.Focus();

            }

            if (mtbcpf.Text.Trim().Length != 14)
            {
                massage.AppendLine("cpf incorreto \n\r");
                mtbcpf.Focus();

            }
            if (DateTime.Equals(new DateTime(DTFuncinarioCadastroDTNacimento.Value.Year, DTFuncinarioCadastroDTNacimento.Value.Month,
                               DTFuncinarioCadastroDTNacimento.Value.Day), new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day)))
            {
                massage.AppendLine("Data de nacimento incorreta \n\r");
                DTFuncinarioCadastroDTNacimento.Focus();

            }
            if (cbSexo.SelectedIndex < 0)
            {
                massage.AppendLine("Selecione o Sexo \n\r");
                cbSexo.DroppedDown = true;

            }
            if (txtEstadoCivil.Text.Length == 0)
            {
                massage.AppendLine("Ectado civil deve ser preenchido \n\r");
                txtEstadoCivil.Focus();

            }
            if (txtEndereso.Text.Length == 0)
            {
                massage.AppendLine("Endereço deve ser preenchido \n\r");
                txtEndereso.Focus();

            }
            if (txtcargo.Text.Length == 0)
            {
                massage.AppendLine("Cargo deve ser preenchido \n\r");
                txtcargo.Focus();

            }



            if (massage.ToString().Trim().Length != 0)
            {
                MessageBox.Show(massage.ToString());
                return;
            }
            funcionario funcionario = new funcionario();
            funcionario.nome = txtNome.Text;
            funcionario.curso = txtCurso.Text;
            funcionario.nacionalidade = txtFuncionarioNacionalidade.Text;
            funcionario.numeroCelular = mtbNumeroCelular.Text;
            funcionario.nFixo = mtbNumeroFixo.Text;
            funcionario.email = txtEmail.Text;
            funcionario.RG = mtbcpf.Text;
            funcionario.CPF = mtbRG.Text;
            funcionario.dataNacimento = DTFuncinarioCadastroDTNacimento.Value;
            funcionario.sexo = cbSexo.Text;
            funcionario.estadoCivil = txtEstadoCivil.Text;
            funcionario.endereso = txtEndereso.Text;
            funcionario.cargo = txtcargo.Text;

            FuncionarioObserver.addFuncionario(funcionario);

        }

        private void linpar()
        {
            txtNome.Text = "";
            txtCurso.Text = "";
            txtFuncionarioNacionalidade.Text = "";
            mtbNumeroCelular.Text = "";
            mtbNumeroFixo.Text = "";
            txtEmail.Text = "";
            mtbcpf.Text = "";
            mtbRG.Text = "";
            DTFuncinarioCadastroDTNacimento.Value =DateTime.Now;
            cbSexo.Text = "";
            txtEstadoCivil.Text = "";
            txtEndereso.Text = "";
            txtcargo.Text = "";

        }











        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void btcancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            FuncionarioObserver.atualivarGrid();
        }
    }
}



