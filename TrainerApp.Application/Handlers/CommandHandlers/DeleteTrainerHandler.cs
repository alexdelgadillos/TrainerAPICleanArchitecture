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
    public class DeleteTrainerHandler : IRequestHandler<DeleteTrainerCommand, DeleteResponse>
    {
        private readonly ITrainerRepository _trainerRepository;

        public DeleteTrainerHandler(ITrainerRepository trainerRepository)
        {
            _trainerRepository = trainerRepository;
        }

        public async Task<DeleteResponse> Handle(DeleteTrainerCommand request, CancellationToken cancellationToken)
        {
            var trainerentity = TrainerMapper.Mapper.Map<Trainer>(request);
            if (trainerentity is null)
            {
                throw new ApplicationException("Issue with mapper");
            }

            var deleteTrainer = await _trainerRepository.DeleteAsync(trainerentity); //duda addasync
            var trainerResponse = TrainerMapper.Mapper.Map<DeleteResponse>(deleteTrainer);
            return trainerResponse;
        }
    }
}