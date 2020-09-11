using Erecruta.Domain;
using Erecruta.Interface;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Repository 
{
    public class IBGERepository : IIBGERepository
    {
        public List<Estado> ListaEstado()
        {
            var client = new RestClient("https://servicodados.ibge.gov.br/api/v1/localidades/estados");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);

            var lista = JsonConvert.DeserializeObject<List<Estado>>(response.Content);

            return lista;
        }

        public List<Cidade> ListaCidade(long estadoId)
        {
            var client = new RestClient($"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{estadoId.ToString()}/municipios");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);

            var lista = JsonConvert.DeserializeObject<List<Cidade>>(response.Content);

            return lista;
        }
    }
}
