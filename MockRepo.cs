using DesafioPratico.Dtos;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DesafioPratico
{
    public class MockRepo
    {
        public List<PessoaDto> Pessoas { get; set; }

        public MockRepo() {
            var pessoasFile = File.ReadAllText("./Pessoas.json");
            Pessoas = JsonSerializer.Deserialize<List<PessoaDto>>(pessoasFile) ?? new List<PessoaDto>();
        }
    }
}
