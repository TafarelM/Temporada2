using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//add
using AcessoBancoDados_DAL;
using ObjetoTransferencia_DTO;

namespace RegrasNegocios_BLL
{
    public class PedidoItemBLL
    {
        //INSERIR
        public String Inserir(PedidoItem pedidoItem)
        {
            try
            {
                PedidoItemDAL pedidoItemDAL = new PedidoItemDAL();
                String idProduto = pedidoItemDAL.Inserir(pedidoItem);

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
            PedidoItemDAL pedidoItemDAL = new PedidoItemDAL();
            PedidoItemColecao pedidoItemColecao = new PedidoItemColecao();

            pedidoItemColecao = pedidoItemDAL.ConsultarID(idPedido);

            return pedidoItemColecao;
        }
//
    }
}
