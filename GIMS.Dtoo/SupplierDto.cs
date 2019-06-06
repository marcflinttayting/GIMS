using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIMS.Dto
{
    public class SupplierRequestDto
    {
        public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
    }

    public class SupplierResponseDto
    {
        public int Id { get; set; }
        public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
    }
}
