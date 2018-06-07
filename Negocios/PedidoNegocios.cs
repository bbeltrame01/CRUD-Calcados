using AcessoBancoDados;
using ObjetoTransferencia2;
using System;
using System.Data;

namespace Negocios
{
    public class PedidoNegocios
    {
        AcessoDadosSQLServer acessoDados = new AcessoDadosSQLServer();

        //Inserir
        public string Inserir(Pedido pedido)
        {
            try
            {
                acessoDados.limparParametros();
                acessoDados.addParametros("@idOperacao_pedido", pedido.Operacao.idOperacao);
                acessoDados.addParametros("@idSituacao_pedido", pedido.Situacao.idSituacao);
                acessoDados.addParametros("@idFuncionario_pedido", pedido.Funcionario.idPessoa);
                acessoDados.addParametros("@idCliente_pedido", pedido.Cliente.idPessoa);

                string idPedido = acessoDados.executarAlteracao(CommandType.StoredProcedure, "InserirPedido").ToString();

                return idPedido;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        //Consultar
        public PedidoColecao Consultar(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                PedidoColecao pedidoColecao = new PedidoColecao();

                acessoDados.limparParametros();
                acessoDados.addParametros("@dataInicial", dataInicial);
                acessoDados.addParametros("@dataFinal", dataFinal);

                DataTable dataTable = acessoDados.executarConsulta(CommandType.StoredProcedure, "ConsultarPedidoPorData");

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Pedido pedido = new Pedido();

                    pedido.idPedido = Convert.ToInt32(dataRow["Id"]);
                    pedido.dataHora = Convert.ToDateTime(dataRow["dataHora_pedido"]);
                    pedido.Funcionario = new Pessoa();
                    pedido.Funcionario.Nome = Convert.ToString(dataRow["Funcionario"]);
                    pedido.Cliente = new Pessoa();
                    pedido.Cliente.Nome = Convert.ToString(dataRow["Cliente"]);
                    pedido.Operacao = new Operacao();
                    pedido.Operacao.Descricao = Convert.ToString(dataRow["Operação"]);
                    pedido.Situacao = new Situacao();
                    pedido.Situacao.Descricao = Convert.ToString(dataRow["Situação"]);

                    pedidoColecao.Add(pedido);
                }

                return pedidoColecao;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao consultar pedido. Detalhes: " +
                    ex.Message);
            }
        }

    }
}
