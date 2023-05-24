using EcommerceDosGuri.Application.DomainModel.BaseEntity;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected readonly AppDb _db;

        public BaseRepository(AppDb db)
        {
            _db = db;
        }

        public async Task<IReadOnlyCollection<T>> GetAllAsync()
        {
            IReadOnlyCollection<T> entities = await _db.Set<T>().ToListAsync();

            return entities;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            T entity = await _db.Set<T>().FindAsync(id);

            return entity;
        }

        public async Task AddAsync(T entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _db.Update(entity);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Remove(entity);
            await _db.SaveChangesAsync();
        }
    }
}
