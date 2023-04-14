using Biblioteca_MCF.Enums;

namespace Biblioteca_MCF.Models.Usuario
{
    public abstract class PessoaModel
    {

        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? CPF { get; set; }
        public string DataNascimento { get; set; }
        public int? NumCelular { get; set; }
        public string[] Endereco { get; set; }
        public StatusUsuarioEnum Status { get; set; }
        public DateTime DataCadastro { get; set; }
		public DateTime? DataAtualizacao { get; set; }
	}
}
