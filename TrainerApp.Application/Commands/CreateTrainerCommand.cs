using System.Collections.Generic;
using MediatR;
using TrainerApp.Application.Responses;
using TrainerApp.Core.Entities;

namespace TrainerApp.Application.Commands
{
    public class CreateTrainerCommand : IRequest<TrainerResponse>
    {
      
        public string Name { get; set; }
        public List<Pokemon> PokemonList { get; set; }
    }
}