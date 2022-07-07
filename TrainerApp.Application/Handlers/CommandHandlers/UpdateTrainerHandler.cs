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
    public class UpdateTrainerHandler: IRequestHandler<UpdateTrainerCommand, TrainerResponse>
    {
    
        private readonly ITrainerRepository _trainerRepository;
        
        public UpdateTrainerHandler(ITrainerRepository trainerRepository)
        {
            _trainerRepository = trainerRepository;
        }

        public async Task<TrainerResponse> Handle(UpdateTrainerCommand request, CancellationToken cancellationToken)
        {
            var trainerentity = TrainerMapper.Mapper.Map<Trainer>(request);
            if (trainerentity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var updatedTrainer = await _trainerRepository.UpdateAsync(trainerentity); //duda addasync
            var trainerResponse = TrainerMapper.Mapper.Map<TrainerResponse>(updatedTrainer);
            return trainerResponse;

        }
    }
    
        
    
}