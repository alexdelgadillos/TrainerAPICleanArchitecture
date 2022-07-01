using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrainerApp.Core.Entities
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Pokemon> PokemonList { get; set; }

    }
}