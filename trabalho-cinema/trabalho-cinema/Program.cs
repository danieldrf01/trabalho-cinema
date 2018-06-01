using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_cinema
{
    static class Program
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Programacao> programacoes = new List<Programacao>();
        public static List<Fornecedor> fornecedores = new List<Fornecedor>();
        public static List<Equipamento> equipamentos = new List<Equipamento>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
}
