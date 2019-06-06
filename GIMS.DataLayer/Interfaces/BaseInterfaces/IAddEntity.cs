using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIMS.DataLayer.Interfaces
{
    public interface IAddEntity<T>
    {
        T Add(T entity);
        void AddMany(IEnumerable<T> entities);
    }
}
