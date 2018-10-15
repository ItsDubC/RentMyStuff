using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentMyStuff.Services.Interfaces
{
    public interface IService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();

        TEntity GetById(int id);
        Task<TEntity> GetByIdAsync(int id);

        TEntity Add(TEntity entity);
        Task<TEntity> AddAsync(TEntity entity);

        TEntity Update(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);

        void Delete(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
