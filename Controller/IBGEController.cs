using Erecruta.Interface;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Controller
{
    [Route("[controller]")]
    public class IBGEController
    {
        private IIBGEService _service;
        public IBGEController(IIBGEService service) => _service = service;
    }
}
