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
    public partial class ListaProgramacao : Form
    {
        public ListaProgramacao()
        {
            InitializeComponent();
        }

        private void AtualizarLista()
        {
            dgvListaProgramacao.Rows.Clear();
            string busca = txtBusca.Text;

            for (int i = 0; i < Program.programacoes.Count; i++)
            {
                Programacao programacao = Program.programacoes[i];
                if (programacao.Filme.Contains(busca))
                    
                dgvListaProgramacao.Rows.Add(new object[]{
                programacao.Filme, programacao.Mes, programacao.Classificacao, programacao.Audio, programacao.Dimensao,
                programacao.Duracao, programacao.Sala});

            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new CadastroProgramacao().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dgvListaProgramacao.CurrentRow.Index;

            if (linhaSelecionada == null)
            {
                MessageBox.Show("Não tem nenhuma programação  selecionada");
                return;
            }

            linhaSelecionada = dgvListaProgramacao.CurrentRow.Index;
            Programacao programacao = Program.programacoes[linhaSelecionada];
            new CadastroProgramacao(programacao, linhaSelecionada).ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvListaProgramacao == null)
            {
                MessageBox.Show("Não tem nenhuma programação selecionada");
                return;
            }

            int linhaSelecionada = dgvListaProgramacao.CurrentRow.Index;
            Programacao programacao = Program.programacoes[linhaSelecionada];


            DialogResult resultado = MessageBox.Show("Dedeseja apagar " + programacao.Filme + "?",
                "AVISO", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.programacoes.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com sucesso");
            }

            else
            {
                MessageBox.Show("Registro salvo com sucesso");
            }
        }

        private void ListaProgramacao_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void ListaProgramacao_KeyDown(object sender, KeyEventArgs e)
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
    

