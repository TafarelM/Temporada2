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
    public class PedidoItemDAL
    {
        AcessoDados_SQLServer acessoDados = new AcessoDados_SQLServer();

        //INSERIR
        public String Inserir(PedidoItem pedidoItem)
        {
            try
            {
                acessoDados.LimparParamentros();
                acessoDados.AdicionarParametros("@IDPedido", pedidoItem.Pedido.IDPedido);
                acessoDados.AdicionarParametros("@IDProduto", pedidoItem.Produto.IDProduto);
                acessoDados.AdicionarParametros("@Quantidade", pedidoItem.Quantidade);
                acessoDados.AdicionarParametros("@ValorUnitario", pedidoItem.ValorUnitario);
                acessoDados.AdicionarParametros("@PercentualDesconto", pedidoItem.PercentualDesconto);
                acessoDados.AdicionarParametros("@ValorDesconto", pedidoItem.ValorDesconto);
                acessoDados.AdicionarParametros("@ValorTotal", pedidoItem.ValorTotal);

                String idProduto = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "SP_PedidoItem_Inserir").ToString();

                return idProduto;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }
        }

        //CONSULTAR POR ID
        public PedidoItemColecao ConsultarID(int idPedido)
        {
            try
            {
                PedidoItemColecao pedidoItemColecao = new PedidoItemColecao();

                acessoDados.LimparParamentros();
                acessoDados.AdicionarParametros("@IDPedido", idPedido);
                DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "SP_PedidoItem_Consultar");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PedidoItem pedidoItem = new PedidoItem();
                    pedidoItem.Pedido = new Pedido();
                    pedidoItem.Produto = new Produto();

                    pedidoItem.Pedido.IDPedido = Convert.ToInt32(dataRow["IDPedido"]);
                    pedidoItem.Produto.IDProduto = Convert.ToInt32(dataRow["IDProduto"]);
                    pedidoItem.Produto.Descricao = Convert.ToString(dataRow["DescricaoProduto"]);
                    pedidoItem.Quantidade = Convert.ToInt32(dataRow["Quantidade"]);
                    pedidoItem.ValorUnitario = Convert.ToDecimal(dataRow["ValorUnitario"]);
                    pedidoItem.PercentualDesconto = Convert.ToDecimal(dataRow["PercentualDesconto"]);
                    pedidoItem.ValorDesconto = Convert.ToDecimal(dataRow["ValorDesconto"]);
                    pedidoItem.ValorTotal = Convert.ToDecimal(dataRow["ValorTotal"]);

                    pedidoItemColecao.Add(pedidoItem);
                }

                return pedidoItemColecao;
            }
            catch (Exception exception)
            {
                throw new Exception("ERRO AO CONSULTAR ITEM DO PEDIDO. DETALHES: " + exception.Message);
            }
        }
    }
}
