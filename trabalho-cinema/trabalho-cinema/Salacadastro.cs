using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Salacadastro : IModel
    {
        public int id { get; set; }
        public string sala { get; set; }
        
        public string setor { get; set; }
        public string horariodisponivel { get; set; }
        public string Datadisp { get; set; }
        public string quantsalas { get; set; }
        public string quantacentos { get; set; }
        public string tiposacentos { get; set; }
        public string larguraS { get; set; }
        public string nome { get ; set ; }
    }
}
