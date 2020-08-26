using Erecruta.Domain;
using Erecruta.Interface;
using Erecruta.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Service
{
    public class OportunidadeService : IOportunidadeService
    {
        private IOportunidadeRepository _oportunidadeRepository;
        public OportunidadeService(IOportunidadeRepository oportunidadeRepository) => _oportunidadeRepository = oportunidadeRepository;
        public int Incluir(Oportunidade oportunidade)
        {
            if (oportunidade.Titulo == "")
                return 0;

            if (oportunidade.Empresa == "")
                return 0;

            return _oportunidadeRepository.Incluir(oportunidade);
        }

        public void Alterar(Oportunidade oportunidade)
        {
            _oportunidadeRepository.Alterar(oportunidade);
        }
        public List<Oportunidade> Listar()
        {
            return _oportunidadeRepository.Listar();
        }

        public Oportunidade Obter(int Id)
        {
            return _oportunidadeRepository.Obter(Id);
        }
    }
}
