using Erecruta.Domain;
using Erecruta.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Service
{
    public class IBGEService : IIBGEService
    {
        private IIBGERepository _iBGERepository;

        public IBGEService(IIBGERepository iBGERepository) => _iBGERepository = iBGERepository;
        public List<Estado> ListaEstado() => _iBGERepository.ListaEstado();
        public List<Cidade> ListaCidade(long estadoId) => _iBGERepository.ListaCidade(estadoId);
    }
}
