using Microsoft.EntityFrameworkCore;
using TrainerApp.Core.Entities;

namespace TrainerApp.Infraestructure.Data
{
    public class TrainerContext : DbContext
    {

        public TrainerContext(DbContextOptions<TrainerContext> options) : base(options) { }
        public DbSet<Trainer> Trainer
        {
            get;
            set;
        }


    }
}