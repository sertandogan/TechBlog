using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStore.Repository.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {

        private readonly TechBlogDbContext _context;
        public Repository(TechBlogDbContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _context.Set<TEntity>();
            }
            catch (Exception)
            {
                throw new Exception("Couldn't retrieve entities");
            }
        }

        public void Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Add)} entity must not be null");
            }

            try
            {
                if (entity.GetType().GetProperty("IsDeleted") != null)
                {
                    entity.GetType().GetProperty("IsDeleted").SetValue(entity, 0);
                }

                if (entity.GetType().GetProperty("CreationDate") != null)
                {
                    entity.GetType().GetProperty("CreationDate").SetValue(entity, DateTime.Now);
                }

                _context.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be saved");
            }
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Update)} entity must not be null");
            }

            try
            {
                if (entity.GetType().GetProperty("LastUpdatedDate") != null)
                {
                    entity.GetType().GetProperty("LastUpdatedDate").SetValue(entity, DateTime.Now);
                }
                _context.Update(entity);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be updated");
            }
        }

        public void Delete(TEntity entity)
        {
            if (entity.GetType().GetProperty("IsDeleted") != null)
            {
                entity.GetType().GetProperty("IsDeleted").SetValue(entity, 1);

                Update(entity);
            }
            else
            {
                var dbEntityEntry = _context.Entry(entity);

                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                else
                {
                    _context.Attach(entity);
                    _context.Remove(entity);
                }
            }
        }

        public void DeleteHard(TEntity entity)
        {

            var dbEntityEntry = _context.Entry(entity);

            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                _context.Attach(entity);
                _context.Remove(entity);
            }
        }
    }
}
