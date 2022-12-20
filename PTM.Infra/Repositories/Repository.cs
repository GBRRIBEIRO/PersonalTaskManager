using Microsoft.EntityFrameworkCore;
using PTM.Domain.Core;
using PTM.Domain.Tasks;
using PTM.Infra.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Infra.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private ApplicationDataContext _adcontext;
        private DbSet<TEntity> _dbSet;

        public Repository()
        {
            _adcontext = new ApplicationDataContext();
            _dbSet = _adcontext.Set<TEntity>();
        }


        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(Guid id)
        {
             
            return _dbSet.Find(id);
        }

        public void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        public void Update(Guid oldObjectId, TEntity newObject)
        {
            var obj = _dbSet.Find(oldObjectId);
            obj = newObject;
            _dbSet.Update(obj);
        }

        public void Delete()
        {

        }
        
        public void Save()
        {
            _adcontext.SaveChanges();
        }
    }
}
