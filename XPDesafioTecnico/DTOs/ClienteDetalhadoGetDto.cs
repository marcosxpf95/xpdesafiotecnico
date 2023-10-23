namespace XPDesafioTecnico.DTOs
{
    public class ClienteDetalhadoGetDto
    {
        public int ID { get; set; }
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public EnderecoDto EnderecoPrincipal { get; set; }
    }
}
