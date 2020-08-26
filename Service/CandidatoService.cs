using Erecruta.Domain;
using Erecruta.Interface;
using Erecruta.Repository;
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
        public List<Candidato> Listar(int oportunidadeId)
        {
            return _candidatoRepository.Listar(oportunidadeId);
        }

        public Candidato Obter(int id)
        {
            return _candidatoRepository.Obter(id);
        }
    }
}
