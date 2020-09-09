using Erecruta.Domain;
using Erecruta.Interface;
using Erecruta.Model;
using Erecruta.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Service
{
    public class CandidatoService : ICandidatoService
    {
        private ICandidatoRepository _candidatoRepository;
        public CandidatoService(ICandidatoRepository candidatoRepository) => _candidatoRepository = candidatoRepository;

        public int Incluir(Candidato candidato)
        {
            return _candidatoRepository.Incluir(candidato);
        }
        
        public void Alterar(Candidato candidato)
        {
            _candidatoRepository.Alterar(candidato);
        }
        public ListaCandidatoResponse Listar(int oportunidadeId)
        {
            var lista = _candidatoRepository.Listar(oportunidadeId);
            return new ListaCandidatoResponse() { Candidatos = lista, StatusCode = StatusCodes.Status200OK };
        }

        public CandidatoResponse Obter(int id)
        {
            var response = _candidatoRepository.Obter(id);
            return new CandidatoResponse() { Candidato = response, StatusCode = StatusCodes.Status200OK };
        }
    }
}
