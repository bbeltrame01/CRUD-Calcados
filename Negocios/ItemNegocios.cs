using AcessoBancoDados;
using ObjetoTransferencia2;
using System;
using System.Data;

namespace Negocios
{
    public class ItemNegocios
    {
        AcessoDadosSQLServer acessoDados = new AcessoDadosSQLServer();

        public ItemColecao Consultar(int? idItem, string descriItem)
        {
            ItemColecao itemColecao = new ItemColecao();

            acessoDados.limparParametros();

            if (idItem != null)
                acessoDados.addParametros("@id_item", idItem);

            if (descriItem != null)
                acessoDados.addParametros("@descri_item", descriItem);

            DataTable dataTable = acessoDados.executarConsulta(CommandType.StoredProcedure, "ConsultarItemPorCodigoDescri");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Item item = new Item();
                item.Valor = new Preco();

                item.idItem = Convert.ToInt32(dataRow["id_item"]);
                item.Descricao = Convert.ToString(dataRow["descri_item"]);
                item.Valor.Valor = Convert.ToDecimal(dataRow["preco_PcI"]);

                itemColecao.Add(item);
            }

            return itemColecao;
        }
    }
}
