using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_CINEMA
{
    static class Program
    {
<<<<<<< HEAD
=======
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Programacao> programacoes = new List<Programacao>();
        public static List<Fornecedor> fornecedores = new List<Fornecedor>();
        public static List<Equipamento> equipamentos = new List<Equipamento>();

>>>>>>> b1208cb23948a19c5f0404618f18ec358f9bca46
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FuncionarioForm());
        }
    }
}
