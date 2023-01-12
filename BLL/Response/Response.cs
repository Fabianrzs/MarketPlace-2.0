using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Response
{
    public class Response<T> where T : BaseEntity
    {
        public bool Error { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public Response()
        {

        }

        public Response(T data) { 
            Error= false;
            Data= data;
        }

        public Response(string message)
        {
            Error = false;
            Message = message;
        }

    }
}
