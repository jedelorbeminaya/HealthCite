using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HealthCite.Infrastructure.Core
{
    public class HealthCiteRepository
    {
        public class BaseRepository<TEntity> where TEntity : class
        {
            protected readonly MedicalContext _context;

            public BaseRepository(MedicalContext context)
            {
                _context = context;
            }

            public async Task<TEntity> GetByIdAsync(int id)
            {
                return await _context.Set<TEntity>().FindAsync(id);
            }

            public async Task<IEnumerable<TEntity>> GetAllAsync()
            {
                return await _context.Set<TEntity>().ToListAsync();
            }

            public async Task AddAsync(TEntity entity)
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
            }

            public void Update(TEntity entity)
            {
                _context.Set<TEntity>().Update(entity);
                _context.SaveChanges();
            }

            public void Delete(TEntity entity)
            {
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
