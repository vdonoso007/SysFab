using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysFabEAL
{
    public class Response
    {
        public object Object { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
    }
}
