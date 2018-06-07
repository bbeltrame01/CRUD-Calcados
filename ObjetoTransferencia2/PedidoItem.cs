using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia2
{
    public class PedidoItem
    {
        public Pedido Pedido { get; set; }
        public Item Item { get; set; }
        public int Quantidade { get; set; }
        public Decimal valorUnitario { get; set; }
        public Decimal percentualDesconto { get; set; }
        public Decimal valorDesconto { get; set; }
        public Decimal valorTotal { get; set; }
    }
}
