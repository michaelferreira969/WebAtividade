using Biblioteca_MCF.Enums;
using Biblioteca_MCF.Models.Acervo;

namespace Biblioteca_MCF.Rules.Acervo
{
	public class AcervoRules
	{

		public AcervoRules() { }

		public bool ValidaISBN(int isbn)
		{
			return true;
		}

		//Calcular a nota dos leitores e enviar para o acervo
		public int CalculaNotaLeitores(string name)
		{
			//Buscar 
			return 0;
		}

		//Insere status e data nova quando livro é adicionado
		public AcervoModel InsertNew(AcervoModel model)
		{
			model.Status = (StatusAcervoEnum)1;
			model.DataCadastro = DateTime.Now;

			return model;
		}
	}
}
