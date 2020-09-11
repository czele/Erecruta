using Erecruta.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Interface
{
    public interface IIBGERepository
    {
        public List<Estado> ListaEstado();
        public List<Cidade> ListaCidade(long estadoId);
    }
}
