using System;

namespace ObjetoTransferencia_DTO
{
    public class Pedido
    {
        public int IDPedido { get; set; }
        public DateTime DataHora { get; set; }
        public Operacao Operacao { get; set; }
        public Situacao Situacao { get; set; }
        public Pessoa PessoaEmitente { get; set; }
        public Pessoa PessoaDestinatario { get; set; }
    }
}
