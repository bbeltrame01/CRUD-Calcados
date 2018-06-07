using System;

namespace ObjetoTransferencia2
{
    public class EstoqueMovimentado
    {
        public Item Item { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataHora { get; set; }
        public String TipoMovimento { get; set; }
    }
}
