using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_CINEMA
{
   
        public static class FilmeObserver
        {
            private static List<Filme> _filme = new List<Filme>();
            private static List<DataGridView> _gridObserver = new List<DataGridView>();

            public static void addFilme(Filme filme)
            {
                filme.id = _filme.Count + 1;
                _filme.Add(filme);


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
                    grid.DataSource = _filme;
                    grid.Refresh();
                }
            }


        
    }

}

