using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conference.BL.Services
{
    public interface IGenericService<TEntity> where TEntity: class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task<TEntity> Insert(TEntity entity);
        Task<TEntity> Update(int id,TEntity entity);
        Task Delete(int id);
    }
}
