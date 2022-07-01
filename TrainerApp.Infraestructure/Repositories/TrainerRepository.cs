using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainerApp.Core.Entities;
using TrainerApp.Core.Repositories;
using TrainerApp.Infraestructure.Data;

namespace TrainerApp.Infraestructure.Repositories
{
    public class TrainerRepository : Repository<Trainer>, ITrainerRepository
    {
        public TrainerRepository(TrainerContext trainerContext) : base(trainerContext)
        {
        }



        public async Task<IEnumerable<Trainer>> GetTrainerName(string name)
        {
            return await _trainerContext.Trainer.Where(m => m.Name == name).ToListAsync();
        }
    }
}