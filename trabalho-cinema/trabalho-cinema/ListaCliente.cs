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
    public partial class ListaCliente : Form
    {
        public ListaCliente()
        {
            InitializeComponent();
        }

        private void AtualizarLista()
        {
            dgvListaCliente.Rows.Clear();
            string busca = txtBusca.Text;

            for (int i = 0; i < Program.clientes.Count; i++)
            {
                Cliente cliente = Program.clientes[i];
                if (cliente.Nome.Contains(busca) ||
                    cliente.Cpf.Contains(busca))
                
                dgvListaCliente.Rows.Add(new object[]{
                cliente.Nome, cliente.Cpf, cliente.Sexo, cliente.Estado, cliente.Cidade, cliente.Endereco,
                cliente.Cep, cliente.Telefone});
                
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new CadastroCliente().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvListaCliente.CurrentRow.Index;
            
            if (linhaSelecionada == null)
            {
                MessageBox.Show("Não tem nenhum cliente  selecionado");
                return;
            }

            int linhaSelecionada1 = dgvListaCliente.CurrentRow.Index;
            Cliente peca = Program.clientes[linhaSelecionada];
            new CadastroCliente(peca, linhaSelecionada1).ShowDialog();
        
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvListaCliente == null)
            {
                MessageBox.Show("Não tem nenhum cliente selecionado");
                return;
            }

            int linhaSelecionada = dgvListaCliente.CurrentRow.Index;
            Cliente cliente = Program.clientes[linhaSelecionada];


            DialogResult resultado = MessageBox.Show("Dedeseja apagar" + cliente.Nome + " o registro?",
                "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.clientes.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com sucesso");
            }
            
            else
            {
                MessageBox.Show("Registro salvo com sucesso");
            }
          
        }

        private void ListaCliente_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void ListaCliente_KeyDown(object sender, KeyEventArgs e)
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


        }

    }

