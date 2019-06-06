using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIMS.Domain
{
    public enum ErrorCodes
    {
        INTERNAL_ERROR = 500,
        INVALID_REQUEST = 400,
        NOT_FOUND = 404
    }
    public class LogicalErrorException : ApplicationException
    {
        public LogicalErrorException(ErrorCodes code, string description = null, string exception = null)
        {
            Code = code;
            Name = code.ToString();
            Description = description;
#if (DEBUG)
            Exception = exception;
#endif
        }

        public ErrorCodes Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Exception { get; set; }
    }



}
