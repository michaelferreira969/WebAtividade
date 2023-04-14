using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Biblioteca_MCF.Enums;
using Biblioteca_MCF.Models.Acervo;
using Biblioteca_MCF.Rules.Acervo;
using Biblioteca_MCF.Repository.Acervo;

namespace Biblioteca_MCF.Controllers.Acervo
{
	public class AcervoController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Editar()
		{
			return View();
		}

		public ActionResult Cadastro()
		{
			var TipoAcervo = new List<SelectListItem>();
			foreach (TipoAcervoEnum tipo in Enum.GetValues(typeof(TipoAcervoEnum)))
			{
				TipoAcervo.Add(new SelectListItem
				{
					Text = tipo.ToString(),
					Value = ((int)tipo).ToString()
				});
			}

			ViewBag.TipoAcervo = TipoAcervo;
			return View();
		}

		[HttpPost]
		public string CadastrarAcervo(AcervoModel acervo)
		{
			//Regras e validações
			AcervoRules rules = new AcervoRules();

			var result = rules.ValidaISBN(acervo.ISBN);

			if (!result)
				return "Código ISBN inválido!";

			//Insere dados de novo livro
			acervo = rules.InsertNew(acervo);

			//Repositório
			AcervoRepository repository = new AcervoRepository();

			repository.CadastrarAcervo(acervo);

			return "Acervo adicionado com sucesso";
		}

		[HttpGet]
		public List<AcervoModel> SearchAcervos()
		{
			AcervoRepository repository = new AcervoRepository();
			var result = repository.SearchAllAcervos();
			return result;
		}

        [HttpPost]
        public AcervoModel EditAcervo(AcervoModel acervo)
        {
            AcervoRepository repository = new AcervoRepository();
            return repository.EditAcervo(acervo);
        }

        [HttpPost]
        public string DeleteAcervo(int idAcervo)
        {
            AcervoRepository repository = new AcervoRepository();
			repository.DeleteAcervo(idAcervo);

			return "Acervo excluído com sucesso!";
        }

        [HttpPost]
        public string DeleteAllAcervos()
        {
            AcervoRepository repository = new AcervoRepository();
            repository.DeleteAllAcervos();

			return "Acervos deletados com sucesso";
		}
    }
}
