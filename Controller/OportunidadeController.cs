using Erecruta.Domain;
using Erecruta.Interface;
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
        private IOportunidadeService _oportunidadeService;
        public OportunidadeController(IOportunidadeService oportunidadeService) => _oportunidadeService = oportunidadeService;
        
        
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
