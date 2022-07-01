using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TrainerApp.Application.Queries;
using TrainerApp.Core.Entities;
using TrainerApp.Core.Repositories;

namespace TrainerApp.Application.Handlers.QueryHandlers
{
    public class GetAllTrainerHandler : IRequestHandler<GetAllTrainersQuery, List<Trainer>>
    {
    private readonly ITrainerRepository _trainerRepo;

    public GetAllTrainerHandler(ITrainerRepository trainerRepository)
    {
        _trainerRepo = trainerRepository;
    }
  

    public async Task<List<Trainer>> Handle(GetAllTrainersQuery request, CancellationToken cancellationToken)
    {
        return (List<Trainer>)await _trainerRepo.GetAllAsync();
    }
    }
}