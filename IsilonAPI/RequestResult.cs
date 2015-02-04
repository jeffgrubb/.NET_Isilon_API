using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IsilonAPI
{
    public class RequestResult
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public object Content { get; set; }
    }
}
