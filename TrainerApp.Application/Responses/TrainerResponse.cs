using System.Collections.Generic;
using TrainerApp.Core.Entities;

namespace TrainerApp.Application.Responses
{
    public class TrainerResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pokemon> PokemonList { get; set; }
    }
}