using System;

namespace ObjetoTransferencia_DTO
{
    public class PedidoItem
    {
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public Decimal ValorUnitario { get; set; }
        public Decimal PercentualDesconto { get; set; }
        public Decimal ValorDesconto { get; set; }
        public Decimal ValorTotal { get; set; }
    }
}
