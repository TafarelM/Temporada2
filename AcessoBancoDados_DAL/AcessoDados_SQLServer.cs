using AcessoBancoDados_DAL.Properties;
using System;

//add
using System.Data;
using System.Data.SqlClient;

namespace AcessoBancoDados_DAL
{
    public class AcessoDados_SQLServer
    {
        //CRIAR A CONEXÃO
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        //PARAMETROS QUE VÃO PARA O BANCO
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        //LIMPAR PARAMETROS ANTES DE USAR
        public void LimparParamentros()
        {
            sqlParameterCollection.Clear();
        }

        //ADICIONA OS PARAMETROS NO METODO QUE VAI PARA O BANCO
        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //PERSISTENCIA DE DADOS NO BANCO - INSERIR, ALTERAR E EXCLUIR
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSQL)
        {
            try
            {
                //CRIA A CONEXAO
                SqlConnection sqlConnection = CriarConexao();
                //ABRI A CONEXAO
                sqlConnection.Open();
                //CRIA O COMANDO QUE VAI LEVAR A INFORMAÇÃO PARA O BANCO
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //COLOCANDO AS DADOS DENTRO DO COMANDO(DENTRO DO OBJETO QUE VAI TRAFEGAR NA CONEXÃO)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSQL;
                sqlCommand.CommandTimeout = 7200; //em segundos

                //ADICIONA OS PARAMETROS NO COMANDO
                foreach(SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //EXECUTA O COMANDO, MANDA O COMANDO IR ATÉ O BANCO DE DADOS
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //CONSULTA REGISTROS DO BANCO DE DADOS
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSQL)
        {
            try
            {
                //CRIA A CONEXÃO
                SqlConnection sqlConnection = CriarConexao();
                //ABRI CONEXAO
                sqlConnection.Open();
                //CRIA O COMANDO QUE VAI LEVAR A INFORMAÇÃO PARA O BANCO
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //COLOCANDO AS DADOS DENTRO DO COMANDO(DENTRO DO OBJETO QUE VAI TRAFEGAR NA CONEXÃO)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSQL;
                sqlCommand.CommandTimeout = 7200; //em segundos

                //ADICIONA OS PARAMETROS NO COMANDO
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //CRIA UM ADPATADOR
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //DATATABLE = TABELA DE DADOS VAZIA ONDE VOU COLOCAR OS DADOS QUE VEM DO BANCO
                DataTable dataTable = new DataTable();
                //MANDA O COMANDO IR ATÉ O BANCO BUSCAR OS DADOS E O ADAPTADOR PREENCHER O DATATABLE
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
