using Microsoft.AspNetCore.Mvc;

namespace ENG_SW_AWS_Atividade1.Controllers
{
    [ApiController]
    [CacheFilter(TimeDuration = 100)]
    [Route("[controller]")]
    public class AnimaisController : ControllerBase
    {
        List<Animal> animais = new List<Animal>();

        public AnimaisController()
        {
            animais.Add(new Animal { id = 1, nome = "Cachorro" });
            animais.Add(new Animal { id = 2, nome = "Gato" });
            animais.Add(new Animal { id = 3, nome = "Papagaio" });
        }

        [HttpGet(Name = "animais")]
        public List<Animal> Animais()
        {
            return animais;
        }

        [HttpGet("{id}")]
        public Animal Animais(int id)
        {
            return animais.FirstOrDefault(x => x.id == id);
        }
    }

    public class Animal
    {
        public int id { get; set; }
        public string? nome { get; set; }
    }

}