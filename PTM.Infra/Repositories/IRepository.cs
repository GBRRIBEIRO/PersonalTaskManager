using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Infra.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetById(Guid id);
        void Add(TEntity obj);
        void Update(Guid oldObjectId, TEntity newObject);
        void Delete();
        void Save();
    }
}
