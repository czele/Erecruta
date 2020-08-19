using Erecruta.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Erecruta.Repository
{
    public class OportunidadeRepository : BaseRepository
    {

        public int Incluir(Oportunidade oportunidade)
        {
            string query = @"
            INSERT INTO[dbo].[Oportunidade]
            ([Titulo]
                      ,[Empresa]
                      ,[DataHoraCriacao]
                      ,[EstadoId]
                      ,[CidadeId]
                      ,[Regiao]
                      ,[Remuneracao]
                      ,[Regime]
                      ,[Posicao]
                      ,[JobDescription]
                      ,[Situacao])
                 OUTPUT Inserted.Id
                 VALUES
                       (@Titulo
                       , @Empresa
                       , @DataHoraCriacao
                       , @EstadoId
                       , @CidadeId
                       , @Regiao
                       , @Remuneracao
                       , @Regime
                       , @Posicao
                       , @JobDescription
                       , @Situacao)";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.ExecuteScalar<int>(query, oportunidade);
        }

        public void Alterar(Oportunidade oportunidade)
        {
            string query = @"UPDATE [dbo].[Candidato]
                             SET [Nome] = @Nome
                                 ,[Email] = @Email
                                 ,[Celular] = @Celular
                                 ,[LinkedIn] = @LinkedIn
                                 ,[Curriculo] = @Curriculo
                                 ,[Classificacao] = @Classificacao
                                 ,[EstadoId] = @EstadoId
                                 ,[CidadeId] = @CidadeId
                                 ,[Observacao] = @Observacao
                                 ,[Situacao] = @Situacao
                                 ,[OportunidadeId] = @OportunidadeId
                                 ,[Regiao] = @Regiao
                            WHERE Id = @Id";

            var con = new SqlConnection(_connectionString);
            con.Open();
            con.Execute(query, oportunidade);
        }

        public List<Oportunidade> Listar()
        {
            string query = @"SELECT [Id]
                          ,[Titulo]
                          ,[Empresa]
                          ,[DataHoraCriacao]
                          ,[EstadoId]
                          ,[CidadeId]
                          ,[Regiao]
                          ,[Remuneracao]
                          ,[Regime]
                          ,[Posicao]
                          ,[JobDescription]
                          ,[Situacao]
                      FROM [dbo].[Oportunidade]
                      WHERE Situacao = 1
                      ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.Query<Oportunidade>(query).ToList();
        }

        public Oportunidade Obter(int Id)
        {
            string query = @"SELECT [Id]
                          ,[Titulo]
                          ,[Empresa]
                          ,[DataHoraCriacao]
                          ,[EstadoId]
                          ,[CidadeId]
                          ,[Regiao]
                          ,[Remuneracao]
                          ,[Regime]
                          ,[Posicao]
                          ,[JobDescription]
                          ,[Situacao]
                      FROM [dbo].[Oportunidade]
                      WHERE Situacao = 1
                      AND Situacao = 1
                      ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.Query<Oportunidade>(query, new { Id }).FirstOrDefault();
        }


    }
}
