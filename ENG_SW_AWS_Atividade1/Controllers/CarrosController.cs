using Microsoft.AspNetCore.Mvc;

namespace ENG_SW_AWS_Atividade1.Controllers
{
    [ApiController]
    [CacheFilter(TimeDuration=100)]
    [Route("[controller]")]
    public class CarrosController : ControllerBase
    {
        List<Carro> carros = new List<Carro>();

        public CarrosController()
        {
            carros.Add(new Carro { id = 1, nome = "Fusca" });
            carros.Add(new Carro { id = 2, nome = "Gol" });
            carros.Add(new Carro { id = 3, nome = "Palio" });
        }

        [HttpGet(Name = "carros")]
        public List<Carro> Carros()
        {
            return carros;
        }

        [HttpGet("{id}")]
        public Carro Carros(int id)
        {
            return carros.FirstOrDefault(x => x.id == id);
        }
    }

    public class Carro
    {
        public int id { get; set; }
        public string? nome { get; set; }
    }

}