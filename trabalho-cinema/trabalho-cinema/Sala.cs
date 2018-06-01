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
    public partial class Sala : Form
    {
        public Sala()
        {
            InitializeComponent();
        }

        private void Sala_Load(object sender, EventArgs e)
        {

        }

        private void btCatastra_Click(object sender, EventArgs e)
        {
            var dataAtual = DateTime.Now;

            StringBuilder massage = new StringBuilder();

            if (cbNumeroSala.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione o numero de sala \n\r");
                cbNumeroSala.DroppedDown = true;
            }
            if (cbsetor.SelectedIndex < 0)
            {
                massage.AppendLine("Um setor deve ser selecionado \n\r");
                cbNumeroSala.DroppedDown = true;
            }
            if (cbHorarioDisponinel.SelectedIndex < 0)
            {
                massage.AppendLine("Selecione uma data \n\r");
                cbNumeroSala.DroppedDown = true;
            }
            if (cbDataDisponivel.SelectedIndex < 0)
            {
                massage.AppendLine("Deve selecionar uma data \n\r");
                cbNumeroSala.DroppedDown = true;
            }
            if (txtQuantidadeDeSalas.Text.Length == 0)
            {
                massage.AppendLine("Quantidade de salas dave ser preenchida \n\r");
                txtQuantidadeDeSalas.Focus();

            }
            if (txtQuantidadeAcentos.Text.Length == 0)
            {
                massage.AppendLine("Quantidade de acentos dave ser preenchida \n\r");
                txtQuantidadeAcentos.Focus();
            }
            if (cbTipoDeAcento.Text.Length == 0)
            {
                massage.AppendLine("Selecione tipo de aceto \n\r");
                txtQuantidadeAcentos.Focus();
            }
            if (txtLargura.Text.Length == 0)
            {
                massage.AppendLine("Dijite largura da Sals \n\r");
                txtLargura.Focus();
            }
            if (massage.ToString().Trim().Length != 0)
            {
                MessageBox.Show(massage.ToString());
                return;
            }
            salas sala = new salas();
            sala.sala = cbNumeroSala.Text;
            sala.setor = cbsetor.Text;
            sala.horariodisponivel = cbHorarioDisponinel.Text;
            sala.Datadisp = cbDataDisponivel.Text;
            sala.quantsalas = txtQuantidadeDeSalas.Text;
            sala.quantacentos = txtQuantidadeAcentos.Text;
            sala.tiposacentos = cbTipoDeAcento.Text;
            sala.larguraS = txtLargura.Text;

            SalaObeserver.addSala(sala);

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var dataAtual = DateTime.Now;

            StringBuilder massage = new StringBuilder();

            if (cbNumeroSala.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione o numero de sala \n\r");
                cbNumeroSala.DroppedDown = true;
            }
            if (cbsetor.SelectedIndex < 0)
            {
                massage.AppendLine("Um setor deve ser selecionado \n\r");
                cbNumeroSala.DroppedDown = true;
            }
            if (cbHorarioDisponinel.SelectedIndex < 0)
            {
                massage.AppendLine("Selecione uma data \n\r");
                cbNumeroSala.DroppedDown = true;
            }
            if (cbDataDisponivel.SelectedIndex < 0)
            {
                massage.AppendLine("Deve selecionar uma data \n\r");
                cbNumeroSala.DroppedDown = true;
            }
            if(txtQuantidadeDeSalas.Text.Length == 0)
            {
                massage.AppendLine("Quantidade de salas dave ser preenchida \n\r");
                txtQuantidadeDeSalas.Focus();

            }
            if (txtQuantidadeAcentos.Text.Length == 0)
            {
                massage.AppendLine("Quantidade de acentos dave ser preenchida \n\r");
                txtQuantidadeAcentos.Focus();
            }
            if(cbTipoDeAcento.Text.Length == 0)
            {
                massage.AppendLine("Selecione tipo de aceto \n\r");
                txtQuantidadeAcentos.Focus();
            }
            if (txtLargura.Text.Length == 0)
            {
                massage.AppendLine("Dijite largura da Sals \n\r");
                txtLargura.Focus();
            }
            if (massage.ToString().Trim().Length != 0)
            {
                MessageBox.Show(massage.ToString());
                return;
            }
           salas sala = new salas();
            sala.sala=cbNumeroSala.Text;
            sala.setor = cbsetor.Text;
            sala.horariodisponivel = cbHorarioDisponinel.Text;
            sala.Datadisp = cbDataDisponivel.Text;
            sala.quantsalas = txtQuantidadeDeSalas.Text;
            sala.quantacentos = txtQuantidadeAcentos.Text;
            sala.tiposacentos = cbTipoDeAcento.Text;
            sala.larguraS = txtLargura.Text;

           SalaObeserver.addSala(sala);
        }
        private void limpar()
        {
            cbNumeroSala.Text= "";

            cbsetor.Text = "";
            cbHorarioDisponinel.Text = "";
            cbDataDisponivel.Text = "";
            txtQuantidadeDeSalas.Text = "";
            txtQuantidadeAcentos.Text = "";
            cbTipoDeAcento.Text = "";
            txtLargura. Text = "";

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {


            cbNumeroSala.Text = "";

            cbsetor.Text = "";
            cbHorarioDisponinel.Text = "";
            cbDataDisponivel.Text = "";
            txtQuantidadeDeSalas.Text = "";
            txtQuantidadeAcentos.Text = "";
            cbTipoDeAcento.Text = "";
            txtLargura.Text = "";


        }

        private void btCanceral_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btAtualizar_Click(object sender, EventArgs e)
        {
            SalaObeserver.atualivarGrid();
        }

        
    }
}
