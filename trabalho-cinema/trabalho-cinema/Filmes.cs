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
    public partial class Filmes : Form
    {
        public Filmes()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var dataAtual = DateTime.Now;

            StringBuilder massage = new StringBuilder();
            if (txtTitulo.Text.Length == 0)
            {
                massage.AppendLine("Titulo Deve ser preenxido \n\r");
                txtTitulo.Focus();


            }
            if (txtAltores.Text.Length == 0)
            {
                massage.AppendLine("Curso deve conter no mínimo 4 caracteres \n\r");
                txtAltores.Focus();


            }
            if (txtAno.Text.Length == 0)
            {
                massage.AppendLine("Curso deve conter no mínimo 4 caracteres \n\r");
                txtAno.Focus();


            }
            if (txtDurasao.Text.Length == 0)
            {
                massage.AppendLine("Curso deve conter no mínimo 4 caracteres \n\r");
                txtDurasao.Focus();


            }
            if (DateTime.Equals(new DateTime(dTPEstreia.Value.Year, dTPEstreia.Value.Month,
                               dTPEstreia.Value.Day), new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day)))
            {
                massage.AppendLine("Estreia incorreta \n\r");
                dTPEstreia.Focus();

            }
            if (cbSetor.SelectedIndex < 0)
            {
                massage.AppendLine("Selecione o setor \n\r");
                cbSetor.DroppedDown = true;

            }
            if (cbFaixaEtaria.SelectedIndex < 0)
            {
                massage.AppendLine("Selecione uma faixa etaria \n\r");
                cbFaixaEtaria.DroppedDown = true;

            }
            if (txtOrigem.Text.Length == 0)
            {
                massage.AppendLine("Origem deve ser preenchido \n\r");
                txtOrigem.Focus();

            }
            if (DateTime.Equals(new DateTime(dTPpreEstreia.Value.Year, dTPpreEstreia.Value.Month,
                               dTPpreEstreia.Value.Day), new DateTime(dataAtual.Year, dataAtual.Month, dataAtual.Day)))
            {
                massage.AppendLine("Pre-Estreia incorreta \n\r");
                dTPpreEstreia.Focus();

            }
            if (txtAudio.Text.Length == 0)
            {
                massage.AppendLine("Audio deve ser preenchido \n\r");
                txtAudio.Focus();

            }
            if (txtSinop.Text.Length == 0)
            {
                massage.AppendLine("Sinopice deve ser preenchida \n\r");
                txtSinop.Focus();

            }
            if (massage.ToString().Trim().Length != 0)
            {
                MessageBox.Show(massage.ToString());
                return;
            }
            Filme filme = new Filme();
            filme.titulo = txtTitulo.Text;
            filme.autor = txtAltores.Text;
            filme.ano = txtAno.Text;
            filme.duresao = txtDurasao.Text;
            filme.estreia = dTPEstreia.Value;
            filme.setor = cbSetor.Text;
            filme.faixaeteria = cbFaixaEtaria.Text;
            filme.origem = txtOrigem.Text;
            filme.Preestreia = dTPpreEstreia.Value;
            filme.audio = txtAudio.Text;
            filme.sinop = txtSinop.Text;


            FilmeObserver.addFilme(filme);
                }
        private void linpar()
        {
            txtTitulo.Text = "";
            txtAltores.Text = "";
            txtAno.Text = "";
            txtDurasao.Text = "";
            dTPEstreia.Value = DateTime.Now;
            cbSetor.Text = "";
            cbFaixaEtaria.Text = "";
            txtOrigem.Text = "";
            dTPpreEstreia.Value = DateTime.Now;
            txtAudio.Text = "";
            txtSinop.Text = "";


        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            FilmeObserver.atualivarGrid();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



