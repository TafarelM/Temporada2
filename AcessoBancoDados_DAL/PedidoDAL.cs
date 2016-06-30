using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//add
using System.Data;
using ObjetoTransferencia_DTO;

namespace AcessoBancoDados_DAL
{
    public class PedidoDAL
    {
        AcessoDados_SQLServer acessoDados = new AcessoDados_SQLServer();

        //INSERIR
        public String Inserir(Pedido pedido)
        {
            try
            {
                acessoDados.LimparParamentros();
                acessoDados.AdicionarParametros("@IDOperacao", pedido.IDPedido);
                acessoDados.AdicionarParametros("@IDSituacao", pedido.Situacao.IDSituacao);
                acessoDados.AdicionarParametros("@IDPessoaEmitente", pedido.PessoaEmitente.IDPessoa);
                acessoDados.AdicionarParametros("@IDPessoaDestinatario", pedido.PessoaDestinatario.IDPessoa);

                String idPedido = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Pedido_Inserir").ToString();

                return idPedido;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //CONSULTAR
        public PedidoColecao ConsultarPorData(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                PedidoColecao pedidoColecao = new PedidoColecao();

                acessoDados.LimparParamentros();
                acessoDados.AdicionarParametros("@DataInicial", dataInicial);
                acessoDados.AdicionarParametros("@DataFinal", dataFinal);

                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "SP_Pedido_ConsultarPorData");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Pedido pedido = new Pedido();
                    pedido.Operacao = new Operacao();
                    pedido.Situacao = new Situacao();
                    pedido.PessoaEmitente = new Pessoa();
                    pedido.PessoaDestinatario = new Pessoa();

                    pedido.IDPedido = Convert.ToInt32(dataRow["IDPedido"]);
                    pedido.DataHora = Convert.ToDateTime(dataRow["DataHora"]);
                    pedido.Operacao.IDOperacao = Convert.ToInt32(dataRow["IDOperacao"]);
                    pedido.Operacao.Descricao = Convert.ToString(dataRow["DescricaoOperacao"]);
                    pedido.Situacao.IDSituacao = Convert.ToInt32(dataRow["IDSituaca"]);
                    pedido.Situacao.Descricao = Convert.ToString(dataRow["DescricaoSituacao"]);
                    pedido.PessoaEmitente.IDPessoa = Convert.ToInt32(dataRow["IDPessoaEmitente"]);
                    pedido.PessoaEmitente.Nome = Convert.ToString(dataRow["NomeEmitente"]);
                    pedido.PessoaDestinatario.IDPessoa = Convert.ToInt32(dataRow["IDPessoaDestinatario"]);
                    pedido.PessoaDestinatario.Nome = Convert.ToString(dataRow["NomeDestinatario"]);

                    pedidoColecao.Add(pedido);
                }

                return pedidoColecao;
            }
            catch (Exception exception)
            {

                throw new Exception("ERRO AO CONSULTAR PEDIDO POR DATA. DATELHES: " + exception);
            }
        }
    }
}
