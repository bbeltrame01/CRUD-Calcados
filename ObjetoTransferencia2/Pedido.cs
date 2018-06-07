using System;

namespace ObjetoTransferencia2
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public DateTime dataHora { get; set; }
        public Operacao Operacao { get; set; }
        public Situacao Situacao { get; set; }
        public Pessoa Funcionario { get; set; }
        public Pessoa Cliente { get; set; }
    }
}
