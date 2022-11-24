using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front.Entity
{
    public enum methodHttp
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    public class Reply
    {
        public string StatusCode { get; set; }
        public object Data { get; set; }
    }

    

}
