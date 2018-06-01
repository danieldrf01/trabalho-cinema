using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABALHO_CINEMA
{
   public class salas:IModel
    {
        public string sala;
        public string setor;
        public string horariodisponivel;
        public string Datadisp;
        public string quantsalas;
        public string quantacentos;
        public string tiposacentos;
        public string larguraS;

        public int id { get; set; }
        public string nome { get; set ; }
    }
}
