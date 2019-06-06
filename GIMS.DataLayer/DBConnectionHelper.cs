using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace GIMS.DataLayer
{
    public static class DBConnectionHelper
    {
        public static string SQLConnectionString => "Data Source=USER-PC;Initial Catalog=Mycelium;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
