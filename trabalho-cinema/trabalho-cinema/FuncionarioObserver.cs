using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_CINEMA
{
    public static  class FuncionarioObserver
    {
        private static List<funcionario> _funcionarios = new List<funcionario>();
        private static List<DataGridView> _gridObserver = new List<DataGridView>();

        public static void addFuncionario(funcionario funcionario)
        {
            funcionario.id= _funcionarios.Count +1;
            _funcionarios.Add(funcionario);


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
                grid.DataSource = _funcionarios;
                grid.Refresh();
            }
        }
      

    }
}
