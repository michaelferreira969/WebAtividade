using Biblioteca_MCF.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Biblioteca_MCF.Models.Acervo
{
	public class AcervoModel
	{
		public int IdAcervo { get; set; }
		public int ISBN { get; set; }
		public string Titulo { get; set; }
		public string Autor { get; set; }
		public decimal? AvaliacaoLeitores { get; set; }
		public int? AnoPublicacao { get; set; }
		public int NumPag { get; set; }
		public int NumCap { get; set; }
		public StatusAcervoEnum Status { get; set; }
		public TipoAcervoEnum TipoAcervo { get; set; }
		public DateTime DataCadastro { get; set; }
		public DateTime? DataAtualizacao { get; set; }
		public int NumExemplares { get; set; }
		public int IdCadastradoPor { get; set; }
	}
}

