using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Domain.Core
{
    internal interface IEntity
    {
        
    }

    public abstract class Entity: IEntity
    {
        public virtual Guid Id { get; private set; }
        public void SetId(Guid id)
        {
            Id = id;
        }
    }
}
