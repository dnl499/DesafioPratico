using DesafioPratico.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DesafioPratico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {
        private MockRepo repo = new MockRepo();
        [HttpGet]
        public IEnumerable<PessoaDto> Get()
        {
            return repo.Pessoas;
        }
    }
}
