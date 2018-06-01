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
    public partial class CadastroEquipamento : Form
    {
        private int posicao = -1;

        public CadastroEquipamento()
        {
            InitializeComponent();
        }

        public CadastroEquipamento(Equipamento equipamento, int posicao)
        {
            InitializeComponent();
            this.posicao = posicao;

            txtNome.Text = equipamento.Nome;
            cbMaterial.SelectedItem = equipamento.Material;
            cbCor.SelectedItem = equipamento.Cor;
            cbLocal.Text = equipamento.Local;
            txtMarca.Text = equipamento.Marca;
            txtValor.Text = Convert.ToString(equipamento.Valor);
            txtPeso.Text = Convert.ToString(equipamento.Peso);
            dtpDataEquipamento.Value = equipamento.DataEquipamento;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Length < 4)
            {
                MessageBox.Show("O Nome deve conter pelo menos 4 caracteres");
                txtNome.Focus();
                return;
            }

            if (cbMaterial.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um tipo de material");
                cbMaterial.DroppedDown = true;
                return;
            }

            if (cbCor.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma cor");
                cbCor.DroppedDown = true;
                return;
            }

            if (cbLocal.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o local do equipamento");
                cbLocal.DroppedDown = true;
                return;
            }

            if (txtMarca.Text.Length < 4)
            {
                MessageBox.Show("Marca deve conter pelo menos 4 caracteres");
                txtMarca.Focus();
                return;
            }

            if (txtPeso.Text.Length == 0)
            {
                MessageBox.Show("Peso deve ser preenchido");
                txtPeso.Focus();
                return;
            }

            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
            }
            catch 
            {
                MessageBox.Show("Peso deve conter somente números");
                return;
            }

            if (txtValor.Text.Length == 0)
            {
                MessageBox.Show("Valor deve ser preenchido");
            }

            try
            {
                double valor = Convert.ToDouble(txtValor.Text);
            }
            catch 
            {
                MessageBox.Show("Valor deve conter somente números");
                return;
            }

            Equipamento equipamento = new Equipamento()
            {
                Nome = txtNome.Text,
                Material = cbMaterial.Text,
                Cor = cbCor.Text,
                Local = cbLocal.Text,
                Marca= txtMarca.Text,
                Peso = txtPeso.Text,
                Valor = txtValor.Text,
               
            };

            if (posicao >= 0)
            {
                Program.equipamentos[posicao] = equipamento;
                MessageBox.Show("Cadastro alterado com sucesso");
            }

            else
            {
                Program.equipamentos.Add(equipamento);
                MessageBox.Show("Cadastro realizado com sucesso");
            }
                LimparCampos();
                 
            }
            
             private void LimparCampos()
            {
                txtNome.Text = "";
                cbMaterial.SelectedIndex = -1;
                cbCor.SelectedIndex = -1;
                cbLocal.SelectedIndex = -1;
                txtMarca.Text = "";
                txtPeso.Text = "";
                txtValor.Text = "";
            
           }

             private void button1_Click(object sender, EventArgs e)
             {
                 Dispose();
             }

            
             
    }
}
