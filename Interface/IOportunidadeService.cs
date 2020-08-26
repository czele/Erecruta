using Erecruta.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Interface
{
    public interface IOportunidadeService
    {
        public int Incluir(Oportunidade oportunidade);
        public void Alterar(Oportunidade oportunidade);
        public List<Oportunidade> Listar();
        public Oportunidade Obter(int Id);

    }
}
