using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainerApp.Core.Repositories.Base;
using TrainerApp.Infraestructure.Data;

namespace TrainerApp.Infraestructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly TrainerContext _trainerContext;
        public Repository(TrainerContext trainerContext)
        {
            _trainerContext = trainerContext;
        }
        public async Task<T> CreateAsync(T t)
        {
            await _trainerContext.Set<T>().AddAsync(t);
            await _trainerContext.SaveChangesAsync();
            return t;
        }

        public async Task<T> DeleteAsync(T t)
        {
            _trainerContext.Set<T>().Remove(t);
            await _trainerContext.SaveChangesAsync();
            return t;

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _trainerContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _trainerContext.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T t)
        {
              _trainerContext.Set<T>().Update(t);
             await _trainerContext.SaveChangesAsync();
             return t;
        }
        
       
    }
}