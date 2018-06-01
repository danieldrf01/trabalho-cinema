using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_CINEMA
{
   public static class BomboniereObserver
    {
        private static List<BombpniereClass> _Bombonierecadastro = new List<BombpniereClass>();
        private static List<DataGridView> _gridObserver = new List<DataGridView>();

      

        public static void addBomboniere(BombpniereClass Bomb)
        {
            Bomb.id = _Bombonierecadastro.Count + 1;
            _Bombonierecadastro.Add(Bomb);


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
                grid.DataSource = _Bombonierecadastro;
                grid.Refresh();
            }
        }



    }
}
