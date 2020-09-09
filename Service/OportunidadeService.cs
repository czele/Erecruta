using Erecruta.Commons;
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
    public class OportunidadeService : IOportunidadeService
    {
        private IOportunidadeRepository _oportunidadeRepository;
        public INivelRepository _nivelRepository;
        public OportunidadeService(IOportunidadeRepository oportunidadeRepository, INivelRepository nivelRepository)
        {
            _oportunidadeRepository = oportunidadeRepository;
            _nivelRepository = nivelRepository;
        }

        public ListResponse Incluir(Oportunidade oportunidade)
        {
            var listResponse = new List<string>();

            if (oportunidade.Titulo == "")
                listResponse.Add("Título não preenchido");

            if (oportunidade.Empresa == "")
                listResponse.Add("Empresa não preenchida");

            if (oportunidade.EstadoId == 0)
                listResponse.Add("Estado não preenchido");

            if (oportunidade.CidadeId == 0)
                listResponse.Add("Cidade não preenchida");

            if (oportunidade.Regime == "")
                listResponse.Add("Regime de contratação não preenchido");

            if (oportunidade.Posicao == "")
                listResponse.Add("Posição não preenchida");

            if (oportunidade.JobDescription == "")
                listResponse.Add("Job description não preenchido");

            if (listResponse.Count > 0)
                return new ListResponse()
                {
                    Mensagem = "Bad Request",
                    StatusCode = StatusCodes.Status400BadRequest,
                    Erros = listResponse
                };

            oportunidade.DataHoraCriacao = DateTime.Now;
            oportunidade.Id = _oportunidadeRepository.Incluir(oportunidade);

            return new ListResponse() { StatusCode = StatusCodes.Status201Created, Mensagem = "Oportunidade incluida com sucesso." };
        }

        public ListResponse Alterar(Oportunidade oportunidade)
        {
            var listResponse = new List<string>();

            if (oportunidade.Titulo == "")
                listResponse.Add("Título não preenchido");

            if (oportunidade.Empresa == "")
                listResponse.Add("Empresa não preenchida");

            if (oportunidade.EstadoId == 0)
                listResponse.Add("Estado não preenchido");

            if (oportunidade.CidadeId == 0)
                listResponse.Add("Cidade não preenchida");

            if (oportunidade.Regime == "")
                listResponse.Add("Regime de contratação não preenchido");

            if (oportunidade.Posicao == "")
                listResponse.Add("Posição não preenchida");

            if (oportunidade.JobDescription == "")
                listResponse.Add("Job description não preenchido");

            if (listResponse.Count > 0)
                return new ListResponse()
                {
                    Mensagem = "Bad Request",
                    StatusCode = StatusCodes.Status400BadRequest,
                    Erros = listResponse
                };

            oportunidade.DataHoraCriacao = DateTime.Now;
            _oportunidadeRepository.Alterar(oportunidade);

            return new ListResponse() { StatusCode = StatusCodes.Status202Accepted, Mensagem = "Oportunidade alterada com sucesso." };

        }
        public ListaOportunidadeResponse Listar()
        {
            var lista = _oportunidadeRepository.Listar();
            return new ListaOportunidadeResponse() { Oportunidades = lista, StatusCode = StatusCodes.Status200OK };
        }

        public OportunidadeResponse Obter(int id)
        {
            var response = _oportunidadeRepository.Obter(id);

            if (response != null)
            {
                response.Niveis = _nivelRepository.ListarByOportunidade(id);

                TimeSpan timeSpan = (DateTime.Now - response.DataHoraCriacao);
                response.Duracao = timeSpan.RelativeTime();
                return new OportunidadeResponse() { Oportunidade = response, StatusCode = StatusCodes.Status200OK, Mensagem = "Dados obtidos com sucesso." };
            }
            else
                return new OportunidadeResponse() { StatusCode = StatusCodes.Status404NotFound};

        }
    }
}
