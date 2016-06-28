using System;

namespace ObjetoTransferencia_DTO
{
    public class PessoaJuridica
    {
        public Pessoa Pessoa { get; set; }
        public String NomeFantasia { get; set; }
        public String RazaoSocial { get; set; }
        public String CNPJ { get; set; }
        public String InscricaoEstadual { get; set; }
        public DateTime DataFundacao { get; set; }

    }
}
