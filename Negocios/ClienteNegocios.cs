using AcessoBancoDados;
using ObjetoTransferencia2;
using System;
using System.Data;

namespace Negocios
{
    public class ClienteNegocios
    {
        AcessoDadosSQLServer acessoDados = new AcessoDadosSQLServer();

        public ClienteColecao Consultar(int? idCliente, string nome)
        {
            ClienteColecao clienteColecao = new ClienteColecao();

            acessoDados.limparParametros();

            if (idCliente != null)
                acessoDados.addParametros("@id_cli", idCliente);

            if (nome != null)
                acessoDados.addParametros("@nome_cli", nome);

            DataTable dataTable = acessoDados.executarConsulta(CommandType.StoredProcedure, "ConsultarClientePorCodigoNome");

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Cliente cliente = new Cliente();

                cliente.Pessoa = new Pessoa();
                cliente.Pessoa.idPessoa = Convert.ToInt32(dataRow["id_cliente"]);
                cliente.Pessoa.Nome = Convert.ToString(dataRow["Nome_Razao"]);
                cliente.Pessoa.CpfCnpj = Convert.ToString(dataRow["CPF_CNPJ"]);

                clienteColecao.Add(cliente);
            }

            return clienteColecao;
        }


        public string Inserir(Cliente cliente)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();

            acessoDados.limparParametros();

            acessoDados.addParametros("@id_cliente", cliente.Pessoa.idPessoa);
            acessoDados.addParametros("@tipo_pessoa", pessoaFisica.Pessoa.PessoaTipo.idPessoaTipo);
            acessoDados.addParametros("@nome_pessoaFisica", pessoaFisica.Nome);
            acessoDados.addParametros("@cpf_pessoaFisica", pessoaFisica.CPF);
            acessoDados.addParametros("@dtNasc_pessoaFisica", pessoaFisica.dtNascimento);
            acessoDados.addParametros("@cep_pessoa", pessoaFisica.Pessoa.cep);
            acessoDados.addParametros("@uf_pessoa", pessoaFisica.Pessoa.uf);
            acessoDados.addParametros("@cidade_pessoa", pessoaFisica.Pessoa.cidade);
            acessoDados.addParametros("@endereco_pessoa", pessoaFisica.Pessoa.rua);
            acessoDados.addParametros("@numero_pessoa", pessoaFisica.Pessoa.numero);
            acessoDados.addParametros("@bairro_pessoa", pessoaFisica.Pessoa.bairro);
            acessoDados.addParametros("@telefone_pessoa", pessoaFisica.Pessoa.telefone);
            acessoDados.addParametros("@email_pessoa", pessoaFisica.Pessoa.email);

            acessoDados.executarAlteracao(CommandType.StoredProcedure, "InserirPessoaFisica");
            string idCliente = acessoDados.executarAlteracao(CommandType.StoredProcedure, "InserirCliente").ToString();

            return idCliente;
        }
    }
}
