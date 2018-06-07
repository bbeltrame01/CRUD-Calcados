using AcessoBancoDados;
using ObjetoTransferencia2;
using System;
using System.Data;

namespace Negocios
{
    public class FuncionarioNegocios
    {
        AcessoDadosSQLServer acessoDados = new AcessoDadosSQLServer();

        //Consultar por codigo
        public FuncionarioColecao consultarPorCodigo(int idFuncionario)
        {
            FuncionarioColecao funcionarioColecao = new FuncionarioColecao();

            acessoDados.limparParametros();
            acessoDados.addParametros("@id_fun", idFuncionario);

            DataTable dataTable = acessoDados.executarConsulta(CommandType.StoredProcedure, "ConsultarFuncionarioPorCodigo");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Funcionario funcionario = new Funcionario();

                funcionario.Pessoa = new Pessoa();
                funcionario.Pessoa.idPessoa = Convert.ToInt32(dataRow["id_funcionario"]);
                funcionario.Pessoa.Nome = Convert.ToString(dataRow["Nome_Razao"]);
                funcionario.Pessoa.CpfCnpj = Convert.ToString(dataRow["CPF_CNPJ"]);

                funcionarioColecao.Add(funcionario);
            }

            return funcionarioColecao;
        }

        //Consultar por Nome
        public FuncionarioColecao consultarPorNome(string nome)
        {
            FuncionarioColecao funcionarioColecao = new FuncionarioColecao();

            acessoDados.limparParametros();
            acessoDados.addParametros("@nome_fun", nome);

            DataTable dataTable = acessoDados.executarConsulta(CommandType.StoredProcedure, "ConsultarFuncionarioPorNome");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Funcionario funcionario = new Funcionario();

                funcionario.Pessoa = new Pessoa();
                funcionario.Pessoa.idPessoa = Convert.ToInt32(dataRow["id_funcionario"]);
                funcionario.Pessoa.Nome = Convert.ToString(dataRow["Nome_Razao"]);
                funcionario.Pessoa.CpfCnpj = Convert.ToString(dataRow["CPF_CNPJ"]);

                funcionarioColecao.Add(funcionario);
            }

            return funcionarioColecao;
        }
    }
}
