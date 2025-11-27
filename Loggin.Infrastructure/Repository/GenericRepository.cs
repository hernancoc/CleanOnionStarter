using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loggin.Application.Interfaces;
using Loggin.Application.Interfaces.Irepository;
using Loggin.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Loggin.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly LogginContext _context;
        private readonly DbSet<T> _dbset;
        public GenericRepository(LogginContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbset.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }

        public async Task Update(T entity)
        {
            _dbset.Update(entity);
           await _context.SaveChangesAsync();  
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
                throw new KeyNotFoundException($"No existe el registro con id {id}");

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

    }
}
