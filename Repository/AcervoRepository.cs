using Microsoft.AspNetCore.Mvc;
using Biblioteca_MCF.Models.Acervo;

namespace Biblioteca_MCF.Repository.Acervo
{
	public class AcervoRepository
	{
		private static List<AcervoModel> listAcervo = new List<AcervoModel>();

		public void CadastrarAcervo(AcervoModel acervo)
		{
			acervo.IdAcervo = listAcervo.Count + 1;
			listAcervo.Add(acervo);
		}
		public List<AcervoModel> SearchAllAcervos()
		{
			return listAcervo;
		}

		public AcervoModel EditAcervo(AcervoModel acervo)
		{
			listAcervo.RemoveAll(i => i.IdAcervo == acervo.IdAcervo);

			AcervoModel newAcervo = new AcervoModel();

			newAcervo.ISBN = acervo.ISBN;
			newAcervo.Titulo = acervo.Titulo;
			newAcervo.Autor = acervo.Autor;
			newAcervo.AnoPublicacao = acervo.AnoPublicacao;
			newAcervo.Status = acervo.Status;

			return newAcervo;
		}

		public void DeleteAcervo(int idAcervo)
		{
			listAcervo.RemoveAll(i => i.IdAcervo == idAcervo);
		}

		public void DeleteAllAcervos()
		{
			listAcervo.Clear();
		}

		public AcervoModel SearchISBN(int isbn)
		{
			return listAcervo.FirstOrDefault(acervo => acervo.ISBN == isbn);
		}
    }
}
