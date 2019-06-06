using GIMS.DataLayer.Interfaces;
using GIMS.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GIMS.Domain.dto;

namespace GIMS.Domain
{
    public class SupplierManager
    {
        private static ISupplierRepository _dal;

        public SupplierManager(ISupplierRepository repo)
        {
            _dal = _dal ?? repo; 
        }

        public int Add(SupplierRequestDto request)
        {
            if (request == null)
                throw new LogicalErrorException(ErrorCodes.INVALID_REQUEST, "Invalid request parameters.");

            var result = JsonConvert.DeserializeObject<Supplier>(JsonConvert.SerializeObject(request));


           // result.CreatedAt = DateTime.UtcNow;
         //   result.UpdatedAt = DateTime.UtcNow;

            return _dal.Add(result).Id; //TODO
        }

        public List<SupplierResponseDto> GetAll()
        {
            //TODO caching

            return JsonConvert.DeserializeObject<List<SupplierResponseDto>>(JsonConvert.SerializeObject(_dal.GetAll()));
        }
    }
}
