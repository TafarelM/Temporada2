using System;

namespace ObjetoTransferencia_DTO
{
    public class EstoqueMovimentado
    {
        public Filial Filial { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataHora { get; set; }
        public String EntradaSaida { get; set; }
    }
}
