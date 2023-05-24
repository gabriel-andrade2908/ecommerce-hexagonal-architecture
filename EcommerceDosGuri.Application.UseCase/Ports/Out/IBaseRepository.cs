using EcommerceDosGuri.Application.DomainModel.BaseEntity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.Ports.Out
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<IReadOnlyCollection<T>> GetAllAsync();
        public Task<T> GetByIdAsync(Guid id);
        public Task AddAsync(T entity);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
    }
}
