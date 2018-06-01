using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_CINEMA
{
   public static class SalaObeserver
    {
        
            private static List<salas> _Salacadastro = new List<salas>();
            private static List<DataGridView> _gridObserver = new List<DataGridView>();

            public static void addSala(salas sala)
            {
                sala.id = _Salacadastro.Count + 1;
             _Salacadastro.Add(sala);


                atualivarGrid();
            }
            public static void addGrid(DataGridView dataGridView)
            {
                _gridObserver.Add(dataGridView);
            }
            public static void atualivarGrid()
            {
                foreach (var grid in _gridObserver)
                {
                    grid.DataSource = null;
                    grid.DataSource = _Salacadastro;
                    grid.Refresh();
                }
            }


        
    }
}
