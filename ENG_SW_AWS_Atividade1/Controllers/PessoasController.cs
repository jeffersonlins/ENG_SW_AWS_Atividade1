using Microsoft.AspNetCore.Mvc;

namespace ENG_SW_AWS_Atividade1.Controllers
{
    [ApiController]
    [CacheFilter(TimeDuration = 100)]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        public PessoasController()
        {
            pessoas.Add(new Pessoa { id = 1, nome = "Marcelo" });
            pessoas.Add(new Pessoa { id = 2, nome = "João" });
            pessoas.Add(new Pessoa { id = 3, nome = "Maria" });
        }

        [HttpGet(Name = "pessoas")]
        public List<Pessoa> Pessoas()
        {
            return pessoas;
        }

        [HttpGet("{id}")]
        public Pessoa Pessoas(int id)
        {
            return pessoas.FirstOrDefault(x => x.id == id);
        }
    }

    public class Pessoa
    {
        public int id { get; set; }
        public string? nome { get; set; }
    }

}