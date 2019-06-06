using GIMS.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIMS.DataLayer.Interfaces
{
    public interface ISupplierRepository : IGetEntity<Supplier,Guid>,
                                           IAddEntity<Supplier>,
                                           IUpdateEntity<Supplier>,
                                           IRemoveEntity<Guid>
    {

    }
}
