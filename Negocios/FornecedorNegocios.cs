using AcessoBancoDados;
using ObjetoTransferencia2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class FornecedorNegocios
    {
        AcessoDadosSQLServer acessoDados = new AcessoDadosSQLServer();

        public FornecedorColecao Consultar(int? idFornecedor, string nome)
        {
            FornecedorColecao fornecedorColecao = new FornecedorColecao();

            acessoDados.limparParametros();

            if (idFornecedor != null)
                acessoDados.addParametros("@id_for", idFornecedor);

            if (nome != null)
                acessoDados.addParametros("@nome_for", nome);

            DataTable dataTable = acessoDados.executarConsulta(CommandType.StoredProcedure, "ConsultarFornecedorPorCodigoNome");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Fornecedor fornecedor = new Fornecedor();

                fornecedor.Pessoa = new Pessoa();
                fornecedor.Pessoa.idPessoa = Convert.ToInt32(dataRow["id_fornecedor"]);
                fornecedor.Pessoa.Nome = Convert.ToString(dataRow["Nome_Razao"]);
                fornecedor.Pessoa.CpfCnpj = Convert.ToString(dataRow["CPF_CNPJ"]);

                fornecedorColecao.Add(fornecedor);
            }

            return fornecedorColecao;
        }
    }
}
