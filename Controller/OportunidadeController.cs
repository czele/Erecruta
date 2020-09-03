using Erecruta.Domain;
using Erecruta.Interface;
using Erecruta.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Erecruta.Controller
{
    [Route("[controller]")]
    public class OportunidadeController : ControllerBase
    {
        private IOportunidadeService _oportunidadeService;
        public OportunidadeController(IOportunidadeService oportunidadeService) => _oportunidadeService = oportunidadeService;
        
        
        [HttpPost("incluir")]

        public IActionResult Incluir([FromBody]Oportunidade oportunidade)
        {

            try
            {
                var resultado = _oportunidadeService.Incluir(oportunidade);
                return new ObjectResult(resultado) { StatusCode = resultado.SatatusCode };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        [HttpPut("alterar")]
        public IActionResult Alterar(Oportunidade oportunidade)
        {
            try
            {
                _oportunidadeService.Alterar(oportunidade);
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status200OK };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        [HttpGet("listar")]
        public IActionResult Listar()
        {
            try
            {
                var resultado = _oportunidadeService.Listar();
                return new ObjectResult(resultado) { StatusCode = resultado.SatatusCode };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        [HttpGet("obter")]
        public IActionResult Obter(int id)
        {
            try
            {
                var resultado = _oportunidadeService.Obter(id);
                return new ObjectResult(resultado) { StatusCode = resultado.SatatusCode };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
