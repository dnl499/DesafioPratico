namespace DesafioPratico.Dtos
{
    public class PessoaDto
    {
        public string Cpf { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public int Idade { get; set; } = -1;
        public string Municipio { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}
