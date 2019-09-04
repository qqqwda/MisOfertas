using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisOfertas.CapaDatos
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Answer { get; set; }

        public Response()
        {
            IsSuccess = false;
            //Answer = null;
        }
    }
}
