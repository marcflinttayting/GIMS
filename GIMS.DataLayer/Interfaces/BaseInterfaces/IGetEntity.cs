using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIMS.DataLayer.Interfaces
{
    public interface IGetEntity<T, EntityId>
    {
        T Get(EntityId id);
        T Get(string query);
        IEnumerable<T> GetMany(string query);
        IEnumerable<T> GetMany(EntityId id);
        IEnumerable<T> GetAll();
    }
}
