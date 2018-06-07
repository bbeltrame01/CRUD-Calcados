using System;

namespace ObjetoTransferencia2
{
    public class Item
    {
        public int idItem { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime dtFabricacao { get; set; }
        public int Garantia { get; set; }
        public Preco Valor { get; set; }
    }
}
