using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIMS.Domain.dto
{
    public sealed class SupplierRequestDto
    {
        //public int Id { get; set; } 
        public Guid SupplierId { get; set; }
        public string Name { get; set; } // varchar(150)
        public string Address { get; set; } // varchar(300)
        public string ContactNumber { get; set; } // varchar(30)
        public bool IsActive { get; set; } 
        public string Remarks { get; set; } // varchar(500
    }

    public sealed class SupplierResponseDto
    {
        public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public bool IsActive { get; set; }
        public string Remarks { get; set; } 
    }
}
