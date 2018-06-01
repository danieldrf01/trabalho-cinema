namespace TRABALHO_CINEMA
{
    public class Filme : IModel
    {
        public int id { get ; set ; }
        public string nome { get ; set ; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string ano { get; set; }
        public string duresao { get; set; }
        public System.DateTime estreia { get; set; }
        public string setor { get; set; }
        public string faixaeteria { get; set; }
        public string origem { get; set; }
        public System.DateTime Preestreia { get; set; }
        public string audio { get; set; }
        public string sinop { get; set; }

    }
}