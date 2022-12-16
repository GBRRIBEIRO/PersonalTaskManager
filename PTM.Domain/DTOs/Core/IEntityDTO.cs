using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Domain.DTOs.Core
{
    internal interface IEntityDTO
    {
    }

    public abstract class EntityDTO
    {
        public Guid Id { get; set; }
    }
}
