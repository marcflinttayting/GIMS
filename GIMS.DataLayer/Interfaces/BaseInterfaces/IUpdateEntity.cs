using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIMS.DataLayer.Interfaces
{
    public interface IUpdateEntity<T>
    {
        T Update(T entity);
    }
}
