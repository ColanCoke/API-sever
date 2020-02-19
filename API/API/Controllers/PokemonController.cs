using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/Pokemon")]
    public class PokemonController : Controller
    {

        public static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Sableye", Strength = 63},
            new Pokemon() {Name = "Blaziken", Strength = 100},
            new Pokemon() {Name = "Dialga", Strength = 752}
        };

        [HttpGet]
        public ActionResult Get()
        {
           /* Pokemon p = new Pokemon();
            p.Name = "Ekans";
            p.Strength = 67;*/

            return Ok(pokemons);
        }

        [HttpPost]
        public ActionResult AddNew(Pokemon newPokemon)
        {
            pokemons.Add(newPokemon);
            Console.WriteLine("Added " + newPokemon.Name);



        }

    }
}