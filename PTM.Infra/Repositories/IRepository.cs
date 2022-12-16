using PTM.Infra.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Infra.Repositories
{
    public class Repository<T>
    {
        private Repository(ApplicationDataContext adc)
        {
            adc = new ApplicationDataContext();
        }

        public List<T> GetAll()
        {

            return new List<T>();
        }
    }
}
