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


        public string InserirPF(Cliente cliente)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            Pessoa pessoa = new Pessoa();

            acessoDados.limparParametros();

            acessoDados.addParametros("@id_cliente", cliente.Pessoa.idPessoa);
            acessoDados.addParametros("@tipo_pessoa", pessoaFisica.Pessoa.PessoaTipo.idPessoaTipo);
            acessoDados.addParametros("@nome_pessoaFisica", pessoaFisica.Nome);
            acessoDados.addParametros("@cpf_pessoaFisica", pessoaFisica.CPF);
            acessoDados.addParametros("@dtNasc_pessoaFisica", pessoaFisica.dtNascimento);
            acessoDados.addParametros("@cep_pessoa", pessoa.cep);
            acessoDados.addParametros("@uf_pessoa", pessoa.uf);
            acessoDados.addParametros("@cidade_pessoa", pessoa.cidade);
            acessoDados.addParametros("@endereco_pessoa", pessoa.rua);
            acessoDados.addParametros("@numero_pessoa", pessoa.numero);
            acessoDados.addParametros("@bairro_pessoa", pessoa.bairro);
            acessoDados.addParametros("@telefone_pessoa", pessoa.telefone);
            acessoDados.addParametros("@email_pessoa", pessoa.email);

            acessoDados.executarAlteracao(CommandType.StoredProcedure, "InserirPessoaFisica");
            string idCliente = acessoDados.executarAlteracao(CommandType.StoredProcedure, "InserirCliente").ToString();

            return idCliente;
        }

        public string InserirPJ(Cliente cliente)
        {

            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            Pessoa pessoa = new Pessoa();

            acessoDados.limparParametros();

            acessoDados.addParametros("@id_cliente", cliente.Pessoa.idPessoa);
            acessoDados.addParametros("@tipo_pessoa", pessoaJuridica.Pessoa.PessoaTipo.idPessoaTipo);
            acessoDados.addParametros("@nome_pessoaFisica", pessoaJuridica.Razao);
            acessoDados.addParametros("@cpf_pessoaFisica", pessoaJuridica.CNPJ);
            acessoDados.addParametros("@cep_pessoa", pessoa.cep);
            acessoDados.addParametros("@uf_pessoa", pessoa.uf);
            acessoDados.addParametros("@cidade_pessoa", pessoa.cidade);
            acessoDados.addParametros("@endereco_pessoa", pessoa.rua);
            acessoDados.addParametros("@numero_pessoa", pessoa.numero);
            acessoDados.addParametros("@bairro_pessoa", pessoa.bairro);
            acessoDados.addParametros("@telefone_pessoa", pessoa.telefone);
            acessoDados.addParametros("@email_pessoa", pessoa.email);

            acessoDados.executarAlteracao(CommandType.StoredProcedure, "InserirPessoaFisica");
            string idCliente = acessoDados.executarAlteracao(CommandType.StoredProcedure, "InserirCliente").ToString();

            return idCliente;
        }
    }
}
