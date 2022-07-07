using MediatR;
using TrainerApp.Application.Responses;

namespace TrainerApp.Application.Commands
{
    public class DeleteTrainerCommand : IRequest<DeleteResponse>
    {
        public int Id { get; set; }
    }
}