using System.ComponentModel.DataAnnotations;

namespace Biblioteca_MCF.Enums
{
	public enum StatusUsuarioEnum
	{
		[Display(Name = "Ativo")]
		Ativo = 1,
		[Display(Name = "Inativo")]
		Inativo = 2,
		[Display(Name = "Bloqueado")]
		Bloqueado = 3
	}
}
