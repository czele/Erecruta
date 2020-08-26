using Erecruta.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Interface
{
    public interface ICandidatoService
    {
        public int Incluir(Candidato candidato);
        public void Alterar(Candidato candidato);
        public List<Candidato> Listar(int oportunidadeId);
        public Candidato Obter(int id);
    }
}
