using Erecruta.Domain;
using Erecruta.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Service
{
    public class OportunidadeService
    {
        private OportunidadeRepository _oportunidadeRepository = new OportunidadeRepository();
        public int Incluir(Oportunidade oportunidade)
        {
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
