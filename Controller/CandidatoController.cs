using Erecruta.Domain;
using Erecruta.Service;
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
        private CandidatoService _candidatoService = new CandidatoService();

        [HttpPost("incluir")]
        public int Incluir(Candidato candidato)
        {
            return _candidatoService.Incluir(candidato);
        }

        [HttpPut("alterar")]
        public void Alterar(Candidato candidato)
        {
            _candidatoService.Alterar(candidato);
        }

        [HttpGet("listar")]
        public List<Candidato> Listar(int oportunidadeId)
        {
            return _candidatoService.Listar(oportunidadeId);
        }

        [HttpGet("obter")]
        public Candidato Obter(int id)
        {
            return _candidatoService.Obter(id);
        }
    }
}
