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
    public partial class ListaEquipamento : Form
    {
        public ListaEquipamento()
        {
            InitializeComponent();
        }

        private void AtualizarLista()
        {
            dgvListaEquipamento.Rows.Clear();
            string busca = txtBusca.Text;

            for (int i = 0; i < Program.equipamentos.Count; i++)
            {
                Equipamento equipamento = Program.equipamentos[i];
                if (equipamento.Nome.Contains(busca))
                    

                dgvListaEquipamento.Rows.Add(new object[]{
                equipamento.Nome, equipamento.Material, equipamento.Cor, equipamento.Local, equipamento.Valor,
                });

            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new CadastroEquipamento().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }






       
    }
}
