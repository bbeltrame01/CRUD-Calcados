using AcessoBancoDados;
using ObjetoTransferencia2;
using System;
using System.Data;

namespace Negocios
{
    public class PedidoItemNegocios
    {
        AcessoDadosSQLServer acessoDados = new AcessoDadosSQLServer();

        public string Inserir(PedidoItem pedidoItem)
        {
            try
            {
                acessoDados.limparParametros();
                acessoDados.addParametros("@idPedido_PI", pedidoItem.Pedido.idPedido);
                acessoDados.addParametros("@idItem_PI", pedidoItem.Item.idItem);
                acessoDados.addParametros("@quantidade_PI", pedidoItem.Quantidade);
                acessoDados.addParametros("@valorUnitario_PI", pedidoItem.valorUnitario);
                acessoDados.addParametros("@percentualDesconto_PI", pedidoItem.percentualDesconto);
                acessoDados.addParametros("@valorDesconto_PI", pedidoItem.valorUnitario);
                acessoDados.addParametros("@valorTotal_PI", pedidoItem.valorTotal);

                string idItem = acessoDados.executarAlteracao(CommandType.StoredProcedure, "InserirItemPedido").ToString();

                return idItem;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        //Consultar
        public PedidoItemColecao Consultar(int idPedido)
        {
            try
            {
                PedidoItemColecao pedidoItemColecao = new PedidoItemColecao();

                acessoDados.limparParametros();
                acessoDados.addParametros("@id_pedido", idPedido);

                DataTable dataTable = acessoDados.executarConsulta(CommandType.StoredProcedure, "ConsultarItensPedido");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    PedidoItem pedidoItem = new PedidoItem();

                    pedidoItem.Pedido = new Pedido();
                    pedidoItem.Pedido.idPedido = Convert.ToInt32(dataRow["Id"]);
                    pedidoItem.Item = new Item();
                    pedidoItem.Item.idItem = Convert.ToInt32(dataRow["CódigoItem"]);
                    pedidoItem.Item.Descricao = Convert.ToString(dataRow["Descricao"]);
                    pedidoItem.Quantidade = Convert.ToInt32(dataRow["quantidade_PI"]);
                    pedidoItem.valorUnitario = Convert.ToDecimal(dataRow["valorUnitario_PI"]);
                    pedidoItem.percentualDesconto = Convert.ToDecimal(dataRow["percentuaDesconto_PI"]);
                    pedidoItem.valorDesconto = Convert.ToDecimal(dataRow["valorDesconto_PI"]);
                    pedidoItem.valorTotal = Convert.ToDecimal(dataRow["valorTotal_PI"]);

                    pedidoItemColecao.Add(pedidoItem);
                }

                return pedidoItemColecao;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao consultar itens do pedido. Detalhes: " +
                    ex.Message);
            }
        }

    }
}
