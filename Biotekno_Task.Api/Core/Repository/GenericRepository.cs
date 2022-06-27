﻿using Biotekno_Task.Api.Core.Entity;
using Biotekno_Task.Api.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biotekno_Task.Api.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private DataContext _context;
        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetAll()
        {
           return _context.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Create(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

        }
    }
}
