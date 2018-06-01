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
    public partial class Bomboriere : Form
    {
        public Bomboriere()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var dataAtual = DateTime.Now;

            StringBuilder massage = new StringBuilder();

            if (txtBombCodigo.Text.Length == 0)
            {
                massage.AppendLine("Codigo dave ser preenchida \n\r");
                txtBombCodigo.Focus();

            }
            if (txtBombNome.Text.Length == 0)
            {
                massage.AppendLine("Nome dave ser preenchida \n\r");
                txtBombNome.Focus();

            }

            if (txtBombSigla.Text.Length == 0)
            {
                massage.AppendLine("Siglas dave ser preenchida \n\r");
                txtBombSigla.Focus();

            }
            if (txtBombSetor.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione o Setor \n\r");
                txtBombSetor.DroppedDown = true;
            }
            if (cbBombTipo.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione o Tipo \n\r");
                cbBombTipo.DroppedDown = true;
            }
            if (txtBOnbFornesedor.Text.Length == 0)
            {
                massage.AppendLine("Fornecedor dave ser preenchida \n\r");
                txtBOnbFornesedor.Focus();

            }
            if (cbBombBQuantidade.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione o quantidade \n\r");
                cbBombBQuantidade.DroppedDown = true;
            }
            if (txtBombPreso.Text.Length == 0)
            {
                massage.AppendLine("Preenchido dave ser preenchida \n\r");
                txtBombPreso.Focus();

            }
            if (cbBombEstecaVenda.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione a Estaçao de venda \n\r");
                cbBombEstecaVenda.DroppedDown = true;
            }
            if (cbBombMarca.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione a Marca \n\r");
                cbBombMarca.DroppedDown = true;


            }

            BombpniereClass bomboniere = new BombpniereClass();
            bomboniere.codigo = txtBombCodigo.Text;
            bomboniere.nome = txtBombNome.Text;
            bomboniere.sigla = txtBombSigla.Text;
            bomboniere.setor = txtBombSetor.Text;
            bomboniere.tipo = cbBombTipo.Text;
            bomboniere.NomeFornecedor = txtBOnbFornesedor.Text;
            bomboniere.quantidade = cbBombBQuantidade.Text;
            bomboniere.preso = txtBombPreso.Text;
            bomboniere.estacaovenda = cbBombEstecaVenda.Text;
            bomboniere.marca = cbBombMarca.Text;


            BomboniereObserver.addBomboniere(bomboniere);

        }
        private void limpar()
        {
            txtBombCodigo.Text = "";
            txtBombNome.Text= "";
            txtBombSigla.Text = "";
            txtBombSetor.Text = "";
            cbBombTipo.Text = "";
            txtBOnbFornesedor.Text = "";
            cbBombBQuantidade.Text = "";
            txtBombPreso.Text = "";
            cbBombEstecaVenda.Text = "";
            cbBombMarca.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBombCodigo.Text = "";
            txtBombNome.Text = "";
            txtBombSigla.Text = "";
            txtBombSetor.Text = "";
            cbBombTipo.Text = "";
            txtBOnbFornesedor.Text = "";
            cbBombBQuantidade.Text = "";
            txtBombPreso.Text = "";
            cbBombEstecaVenda.Text = "";
            cbBombMarca.Text = "";

        }

        private void btBomboriereVoltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            var dataAtual = DateTime.Now;

            StringBuilder massage = new StringBuilder();

            if (txtBombCodigo.Text.Length == 0)
            {
                massage.AppendLine("Codigo dave ser preenchida \n\r");
                txtBombCodigo.Focus();

            }
            if (txtBombNome.Text.Length == 0)
            {
                massage.AppendLine("Nome dave ser preenchida \n\r");
                txtBombNome.Focus();

            }

            if (txtBombSigla.Text.Length == 0)
            {
                massage.AppendLine("Siglas dave ser preenchida \n\r");
                txtBombSigla.Focus();

            }
            if (txtBombSetor.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione o Setor \n\r");
                txtBombSetor.DroppedDown = true;
            }
            if (cbBombTipo.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione o Tipo \n\r");
                cbBombTipo.DroppedDown = true;
            }
            if (txtBOnbFornesedor.Text.Length == 0)
            {
                massage.AppendLine("Fornecedor dave ser preenchida \n\r");
                txtBOnbFornesedor.Focus();

            }
            if (cbBombBQuantidade.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione o quantidade \n\r");
                cbBombBQuantidade.DroppedDown = true;
            }
            if (txtBombPreso.Text.Length == 0)
            {
                massage.AppendLine("Preenchido dave ser preenchida \n\r");
                txtBombPreso.Focus();

            }
            if (cbBombEstecaVenda.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione a Estaçao de venda \n\r");
                cbBombEstecaVenda.DroppedDown = true;
            }
            if (cbBombMarca.SelectedIndex < 0)
            {

                massage.AppendLine("Selecione a Marca \n\r");
                cbBombMarca.DroppedDown = true;


            }

            BombpniereClass bomboniere = new BombpniereClass();
            bomboniere.codigo = txtBombCodigo.Text;
            bomboniere.nome = txtBombNome.Text;
            bomboniere.sigla = txtBombSigla.Text;
            bomboniere.setor = txtBombSetor.Text;
            bomboniere.tipo = cbBombTipo.Text;
            bomboniere.NomeFornecedor = txtBOnbFornesedor.Text;
            bomboniere.quantidade = cbBombBQuantidade.Text;
            bomboniere.preso = txtBombPreso.Text;
            bomboniere.estacaovenda = cbBombEstecaVenda.Text;
            bomboniere.marca = cbBombMarca.Text;


            BomboniereObserver.addBomboniere(bomboniere);

        }

        private void btatualizar_Click(object sender, EventArgs e)
        {
            BomboniereObserver.atualivarGrid();
        }
    }
    
}
