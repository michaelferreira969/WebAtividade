using Biblioteca_MCF.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Biblioteca_MCF.Enums
{
	public enum TipoAcervoEnum
	{
		[Display(Name = "Livro")]
		Livro = 1,
		[Display(Name = "Revista")]
		Revista = 2,
		[Display(Name = "Tese")]
		Tese = 3,
		[Display(Name = "Periódico")]
		Periodico = 4
	}
}
