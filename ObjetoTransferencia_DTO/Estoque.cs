using System;

namespace ObjetoTransferencia_DTO
{
    public class Estoque
    {
        public Filial Filial { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
