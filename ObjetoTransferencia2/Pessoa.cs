using System;

namespace ObjetoTransferencia2
{
    public class Pessoa
    {
        public int idPessoa { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime dtNasc { get; set; }
        public string cep { get; set; }
        public string uf { get; set; }
        public string cidade { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}
