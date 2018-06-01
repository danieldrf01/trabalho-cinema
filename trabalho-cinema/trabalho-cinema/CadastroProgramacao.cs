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
    public partial class CadastroProgramacao : Form
    {
        private int posicao = -1;

        public CadastroProgramacao()
        {
            InitializeComponent();
        }

        public CadastroProgramacao(Programacao programacao, int posicao)
        {
            InitializeComponent();
            this.posicao = posicao;

            txtFilme.Text = programacao.Filme;
            cbMes.SelectedItem = programacao.Mes;
            cbDiaSemanal.SelectedItem = programacao.DiaSemanal;
            txtClassificacao.Text = programacao.Classificacao;
            cbDimensao.Text = Convert.ToString(programacao.Dimensao);
            txtDuracao.Text = programacao.Duracao;
            txtElenco.Text = programacao.Elenco;
            cbAudio.Text = Convert.ToString(programacao.Audio);
            mbHorario.Text = programacao.Horario;
            txtSala.Text = Convert.ToString(programacao.Sala);
            rbEstreia.Text = Convert.ToString(programacao.Estreia);
            rbPreEstreia.Text = Convert.ToString(programacao.PreEstreia);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtFilme.Text.Length < 2)
            {
                MessageBox.Show("Filme deve conter pelo menos 2 caracteres");
                txtFilme.Focus();
                return;
            }

            if (cbMes.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um mês");
                cbMes.DroppedDown = true;
                return;
            }

            if (cbDiaSemanal.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um dia da semana");
                cbDiaSemanal.DroppedDown = true;
                return;
            }

            if (cbDimensao.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma dimensão");
                cbDimensao.DroppedDown = true;
                return;
            }

            if (txtDuracao.Text.Length < 0)
            {
                MessageBox.Show("Digite a duração do filme");
                txtDuracao.Focus();
                return;
            }

            try
            {
                int duracao = Convert.ToInt32(txtDuracao.Text);
            }
            catch 
            {
                MessageBox.Show("A duração do filme deve conter apenas números");
                return;
            }

            if (txtElenco.Text.Length < 0)
            {
                MessageBox.Show("Digite o elenco do filme");
                txtElenco.Focus();
                return;
            }

            if (txtClassificacao.Text.Length < 0)
            {
                MessageBox.Show("Digite a classificação do filme");
                txtClassificacao.Focus();
                return;
            }

            if (cbAudio.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o áudio desejado");
                cbAudio.DroppedDown = true;
                return;
            }

            if (mbHorario.Text.Length < 0)
            {
                MessageBox.Show("Digite o horário do filme");
                mbHorario.Focus();
                return;
            }

            if (txtSala.Text.Length < 0)
            {
                MessageBox.Show("Digite a sala do filme");
                return;
            }

            if (txtSala.Text.Length > 2)
	       {
               MessageBox.Show("A sala do filme deve conter somente 2 digitos");
               txtSala.Focus();
               return;
	       }

           Programacao programacao = new Programacao() 
            {
                Filme = txtFilme.Text,
                Mes = cbMes.Text,
                DiaSemanal = Convert.ToString(cbDiaSemanal.SelectedItem),
                Dimensao = Convert.ToString(cbDimensao.SelectedItem),
                Duracao = txtDuracao.Text,
                Elenco = txtElenco.Text,
                Classificacao = txtClassificacao.Text,
                Audio = Convert.ToString(cbAudio.SelectedItem),
                Horario = mbHorario.Text,
                Sala = txtSala.Text,
                Estreia = rbEstreia.Checked,
                PreEstreia = rbPreEstreia.Checked,
                
            };

            if (posicao >= 0)
            {
                Program.programacoes[posicao] = programacao;
                MessageBox.Show("Cadastro alterado com sucesso");
            }

            else
            {
                Program.programacoes.Add(programacao);
                MessageBox.Show("Cadastro realizado com sucesso");
            }
                LimparCampos();
                 
            }
    
         private void LimparCampos()
        {
            txtFilme.Text = "";
            txtDuracao.Text = "";
            txtElenco.Text = "";
            txtClassificacao.Text = "";
            txtSala.Text = "";
            cbMes.SelectedIndex = -1;
            cbDiaSemanal.SelectedIndex = -1;
            cbAudio.SelectedIndex = -1;
            mbHorario.Text = "";
            cbDimensao.SelectedIndex = -1;
            rbEstreia.Checked = true;
            rbPreEstreia.Checked = true;
                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CadastroProgramacao_Load(object sender, EventArgs e)
        {

        }

        
    }
}
