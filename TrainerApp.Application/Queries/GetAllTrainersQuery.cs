using System.Collections.Generic;
using MediatR;
using TrainerApp.Core.Entities;

namespace TrainerApp.Application.Queries
{
    public class GetAllTrainersQuery : IRequest<List<Trainer>>
    {
    }
}