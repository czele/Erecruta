using Erecruta.Domain;
using Erecruta.Interface;
using Erecruta.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Controller
{
    [Route("[controller]")]
    public class CandidatoController : ControllerBase
    {
        private ICandidatoService _candidatoService;
        public CandidatoController(ICandidatoService candidatoService) => _candidatoService = candidatoService;

        [HttpPost("incluir")]
        public IActionResult Incluir(Candidato candidato)
        {
            try
            {
                var resultado = _candidatoService.Incluir(candidato);
                return new ObjectResult(resultado) { StatusCode = StatusCodes.Status200OK };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        [HttpPut("alterar")]
        public IActionResult Alterar(Candidato candidato)
        {
            try
            {
                _candidatoService.Alterar(candidato);
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status200OK };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }

        [HttpGet("listar")]
        public IActionResult Listar(int oportunidadeId)
        {
            try
            {
                var resultado = _candidatoService.Listar(oportunidadeId);
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
                var resultado = _candidatoService.Obter(id);
                return new ObjectResult(resultado) { StatusCode = resultado.SatatusCode };
            }
            catch (Exception)
            {
                return new ObjectResult(new { }) { StatusCode = StatusCodes.Status500InternalServerError };
            }
        }
    }
}
