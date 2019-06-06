using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIMS.DataLayer.Interfaces
{
    public interface IRemoveEntity<EntityId>
    {
        void Delete(EntityId id);
    }
}
