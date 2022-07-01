using System.Collections.Generic;
using System.Threading.Tasks;
using TrainerApp.Core.Entities;
using TrainerApp.Core.Repositories.Base;

namespace TrainerApp.Core.Repositories
{
    public interface ITrainerRepository : IRepository<Trainer>
    {
        Task<IEnumerable<Trainer>> GetTrainerName(string name);
    }
}