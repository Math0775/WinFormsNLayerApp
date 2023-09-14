using Database.Conexoes;
using Microsoft.Data.SqlClient;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositorios
{
    public class CargoRepositorio
    {
        public bool Inserir(Cargo cargo)
        {
            try
            {               
                var stringConexao = SqlServer.StrConexao();
                var sqlConnection = new SqlConnection(stringConexao);

                sqlConnection.Open();

                var sql = @"INSERT INTO[dbo].[Cargo]
                           ([Nome]
                           ,[Status]
                           ,[CriadoPor]
                           ,[AlteradoEm]
                           ,[AlteradoPor])
                      VALUES
                           (@nome,
                           @status,
                           @criadoEm,
                           @criadoPor,
                           @alteradoEm,
                           @alteradoPor)";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    connection.Open();

                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    cmd.Parameters.AddWithValue("@status", cargo.Status);
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }     
        }
        public bool Atualizar(Cargo cargo) 
        {

            try
            {
                var sql = @"";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@nome", cargo.Nome);
                    
                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Deletar(Cargo cargo) 
        {

            try
            {
                var sql = @"";

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@Id", cargo.Id);

                    var resposta = cmd.ExecuteNonQuery();
                    return resposta == 1;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable ObterTodos(int cargoId) 
        {

            try
            {
                var sql = @"";

                SqlDataAdapter dataAdapter = null;
                var dataTable = new DataTable();

                using (var connection = new SqlConnection(SqlServer.StrConexao()))
                {
                    var cmd = connection.CreateCommand();

                    cmd.CommandText = sql;

                    dataAdapter = new SqlDataAdapter(cmd.CommandText, connection);
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}