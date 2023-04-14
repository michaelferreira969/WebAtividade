namespace Biblioteca_MCF.Models.Usuario
{
	public class UsuarioModel : PessoaModel
	{
	}

	public class ListaUsuarios
	{
		private static readonly ListaUsuarios instancia = new ListaUsuarios();
		private List<PessoaModel> usuarios;

		private ListaUsuarios()
		{
			usuarios = new List<PessoaModel>();
		}

		public static ListaUsuarios Instancia
		{
			get
			{
				return instancia;
			}
		}

		public void AdicionarUsuario(PessoaModel usuario)
		{
			usuarios.Add(usuario);
		}

		public List<PessoaModel> BuscarUsuario()
		{
			return usuarios;
		}

		public PessoaModel BuscarUsuarioPorEmail(string email)
		{
			return usuarios.FirstOrDefault(u => u.Email == email);
		}
	}
}
