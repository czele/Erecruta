using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Model
{
    public class BaseResponse
    {
        public int SatatusCode { get; set; }
        public string Mensagem { get; set; }
    }
}
