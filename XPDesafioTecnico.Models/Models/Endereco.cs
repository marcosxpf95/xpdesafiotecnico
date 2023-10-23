namespace XPDesafioTecnico.Models.Models
{
    public class Endereco
    {
        public int ID { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
    }
}
