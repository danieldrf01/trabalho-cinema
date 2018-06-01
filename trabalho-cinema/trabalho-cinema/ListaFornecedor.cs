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
    public partial class ListaFornecedor : Form
    {
        public ListaFornecedor()
        {
            InitializeComponent();
        }

        private void AtualizarLista()
        {
            dgvListaFornecedor.Rows.Clear();
            string busca = txtBusca.Text;

            for (int i = 0; i < Program.fornecedores.Count; i++)
            {
                Fornecedor fornecedor = Program.fornecedores[i];
                if (fornecedor.Bebida || fornecedor.Alimento == true && (fornecedor.Nome.Contains(busca)))

                    dgvListaFornecedor.Rows.Add(new object[]{
                fornecedor.Nome, fornecedor.Cnpj, fornecedor.Cidade, fornecedor.Numero, fornecedor.Telefone,
                fornecedor.Bairro, fornecedor.Cep});

            }


        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new CadastroFornecedor().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvListaFornecedor.CurrentRow.Index;

            if (linhaSelecionada == null)
            {
                MessageBox.Show("Não tem nenhum fornecedor  selecionado");
                return;
            }

            linhaSelecionada = dgvListaFornecedor.CurrentRow.Index;
            Fornecedor fornecedor = Program.fornecedores[linhaSelecionada];
            new CadastroFornecedor(fornecedor, linhaSelecionada).ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvListaFornecedor == null)
            {
                MessageBox.Show("Não tem nenhum Fornecedor selecionado");
                return;
            }

            int linhaSelecionada = dgvListaFornecedor.CurrentRow.Index;
            Fornecedor fornecedor = Program.fornecedores[linhaSelecionada];


            DialogResult resultado = MessageBox.Show("Dedeseja apagar " + fornecedor.Nome+ "?",
                "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.fornecedores.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com sucesso");
            }

            else
            {
                MessageBox.Show("Registro salvo com sucesso");
            }
        }

             private void ListaFornecedor_Activated(object sender, EventArgs e)
            {
            AtualizarLista();
            }

        private void ListaFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

        private void txtBusca_Leave(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void dgvListaFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AtualizarLista();
            }
        }

        private void txtBusca_Leave_1(object sender, EventArgs e)
        {
            AtualizarLista();
        }
        
    }
}
