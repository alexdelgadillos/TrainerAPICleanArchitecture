using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TrainerApp.Application.Commands;
using TrainerApp.Application.Mappers;
using TrainerApp.Application.Responses;
using TrainerApp.Core.Entities;
using TrainerApp.Core.Repositories;

namespace TrainerApp.Application.Handlers.CommandHandlers
{
    public class CreateTrainerHandler : IRequestHandler<CreateTrainerCommand, TrainerResponse>
    {
        private readonly ITrainerRepository _trainerRepository;
        public CreateTrainerHandler(ITrainerRepository trainerRepository)
        {
            _trainerRepository = trainerRepository;
        }

        public async Task<TrainerResponse> Handle(CreateTrainerCommand request, CancellationToken cancellationToken)
        {
            var trainerentity = TrainerMapper.Mapper.Map<Trainer>(request);
            if (trainerentity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newTrainer = await _trainerRepository.CreateAsync(trainerentity); //duda addasync
            var trainerResponse = TrainerMapper.Mapper.Map<TrainerResponse>(newTrainer);
            return trainerResponse;

        }
    }
}