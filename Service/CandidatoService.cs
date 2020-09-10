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

        public ListResponse Incluir (Candidato candidato)
        {
            var listResponse = new List<string>();

            if (candidato.Nome == "")
                listResponse.Add("Nome não preenchido");
            
            if (candidato.Email == "")
                listResponse.Add("E-mail não preenchido");

            if (candidato.Celular == "")
                listResponse.Add("Celular não preenchido");

            if (candidato.EstadoId == 0)
                listResponse.Add("Estado não preenchido");

            if (candidato.CidadeId == 0)
                listResponse.Add("Cidade não preenchida");

            if (listResponse.Count > 0)
                return new ListResponse()
                {
                    Mensagem = "Bad Request",
                    StatusCode = StatusCodes.Status400BadRequest,
                    Erros = listResponse
                };

            candidato.Id = _candidatoRepository.Incluir(candidato);
            return new ListResponse() { StatusCode = StatusCodes.Status201Created, Mensagem = "Candidato incluido com sucesso." };

        }
        
        public ListResponse Alterar(Candidato candidato)
        {
            var listResponse = new List<string>();

            if (candidato.OportunidadeId == 0)
                listResponse.Add("Oportunidade não preenchida");

            if (candidato.Nome == "")
                listResponse.Add("Nome não preenchido");

            if (candidato.Email == "")
                listResponse.Add("E-mail não preenchido");

            if (candidato.Celular == "")
                listResponse.Add("Celular não preenchido");

            if (candidato.EstadoId == 0)
                listResponse.Add("Estado não preenchido");

            if (candidato.CidadeId == 0)
                listResponse.Add("Cidade não preenchida");

            if (listResponse.Count > 0)
                return new ListResponse()
                {
                    Mensagem = "Bad Request",
                    StatusCode = StatusCodes.Status400BadRequest,
                    Erros = listResponse
                };

            _candidatoRepository.Alterar(candidato);
            return new ListResponse() { StatusCode = StatusCodes.Status201Created, Mensagem = "Candidato alterado com sucesso." };

        }
        public ListaCandidatoResponse Listar(int oportunidadeId)
        {
            var lista = _candidatoRepository.Listar(oportunidadeId);

            if (lista.Count == 0)
                return new ListaCandidatoResponse() { StatusCode = StatusCodes.Status404NotFound };

            return new ListaCandidatoResponse() { Candidatos = lista, StatusCode = StatusCodes.Status200OK };
        }

        public CandidatoResponse Obter(int id)
        {
            var response = _candidatoRepository.Obter(id);

            if (response != null)
            {
                return new CandidatoResponse() { Candidato = response, StatusCode = StatusCodes.Status200OK };
            }
            else
                return new CandidatoResponse() { StatusCode = StatusCodes.Status404NotFound };
        }
    }
}
