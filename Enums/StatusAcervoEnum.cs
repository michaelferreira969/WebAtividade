using System.ComponentModel.DataAnnotations;

namespace Biblioteca_MCF.Enums
{
	public enum StatusAcervoEnum
	{
		[Display(Name = "Disponível")]
		Disponivel = 1,
		[Display(Name = "Reservado")]
		Reservado = 2,
		[Display(Name = "Emprestado")]
		Emprestado = 3,
		[Display(Name = "Bloquado")]
		Bloquado = 4
	}
}
