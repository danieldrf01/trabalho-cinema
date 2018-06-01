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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ListaCliente().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new ListaProgramacao().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new ListaFornecedor().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new ListaEquipamento().Show();
        }
    }
}
