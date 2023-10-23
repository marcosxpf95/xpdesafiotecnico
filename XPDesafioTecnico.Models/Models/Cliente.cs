namespace XPDesafioTecnico.Models.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco EnderecoPrincipal { get; set; }
    }
}
