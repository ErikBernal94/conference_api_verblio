using Conference.DL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Conference.BL.Repositories.Implements
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity: class 
    {
        private readonly ConferenceContext conferenceContext;

        public GenericRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }

        public async Task Delete(int id)
        {
            TEntity entity = await GetById(id);
            if (entity == null)
                throw new Exception("La entidad es nula");
            conferenceContext.Set<TEntity>().Remove(entity);
            await conferenceContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await conferenceContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await conferenceContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            conferenceContext.Set<TEntity>().Add(entity);
            await conferenceContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(int id, TEntity entity)
        {
            TEntity _entity = await GetById(id);
            if (_entity == null)
                throw new Exception("La entidad es nula");
            _entity = entity;
            conferenceContext.Entry(_entity).State = EntityState.Modified;
            await conferenceContext.SaveChangesAsync();
            return entity;
        }
    }
}
