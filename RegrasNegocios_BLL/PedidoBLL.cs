using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//add
using ObjetoTransferencia_DTO;
using AcessoBancoDados_DAL;

namespace RegrasNegocios_BLL
{
    public class PedidoBLL
    {
        //INSERIR
        public String Inserir(Pedido pedido)
        {
            try
            {
                PedidoDAL pedidoDAL = new PedidoDAL();
                String idPedido = pedidoDAL.Inserir(pedido);

                return idPedido;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //CONSULTAR POR DATA
        public PedidoColecao ConsultarPorData(DateTime dataInicial, DateTime dataFinal)
        {
            PedidoDAL pedidoDAL = new PedidoDAL();
            PedidoColecao pedidoColecao = new PedidoColecao();

            pedidoColecao = pedidoDAL.ConsultarPorData(dataInicial, dataFinal);

            return pedidoColecao;
        }
    }
}
