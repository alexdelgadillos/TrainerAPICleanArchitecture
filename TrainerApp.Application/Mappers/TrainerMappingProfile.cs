using AutoMapper;
using TrainerApp.Application.Commands;
using TrainerApp.Application.Responses;
using TrainerApp.Core.Entities;

namespace TrainerApp.Application.Mappers
{
    public class TrainerMappingProfile : Profile
    {
        public TrainerMappingProfile()
        {
            CreateMap<Trainer, TrainerResponse>().ReverseMap();
            CreateMap<Trainer, CreateTrainerCommand>().ReverseMap();
            CreateMap<Trainer, UpdateTrainerCommand>().ReverseMap();
            CreateMap<Trainer, DeleteTrainerCommand>().ReverseMap();


        }


    }
}