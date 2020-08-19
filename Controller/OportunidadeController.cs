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
    public class OportunidadeController : ControllerBase
    {
        private OportunidadeService _oportunidadeService = new OportunidadeService();
        [HttpPost("incluir")]

        public int Incluir(Oportunidade oportunidade)
        {
            return _oportunidadeService.Incluir(oportunidade);
        }

        [HttpPut("alterar")]
        public void Alterar(Oportunidade oportunidade)
        {
            _oportunidadeService.Alterar(oportunidade);
        }

        [HttpGet("listar")]
        public List<Oportunidade> Listar()
        {
            return _oportunidadeService.Listar();
        }

        [HttpGet("obter")]
        public Oportunidade Obter(int id)
        {
            return _oportunidadeService.Obter(id);
        }
    }
}
