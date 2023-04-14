using Microsoft.AspNetCore.Mvc;
using Biblioteca_MCF.Models.Usuario;
using System.Collections.Generic;
using System.Runtime.InteropServices.ObjectiveC;

namespace Biblioteca_MCF.Controllers
{
	public class UsuarioController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.titlePage = "Usuários";
			return View();
		}

		public IActionResult Cadastro()
		{
			ViewBag.titlePage = "Cadastro de Usuários";
			return View();
		}

		[HttpPost]
		public void CadastrarUsuario(UsuarioModel data)
		{
			data.DataCadastro = DateTime.Now;
			data.Status = Enums.StatusUsuarioEnum.Ativo;
			ListaUsuarios.Instancia.AdicionarUsuario(data);
		}

		public void BuscarUsuario()
		{
/*			List<PessoaModel> listaUsuarios = new List<PessoaModel>();
			listaUsuarios = UsuarioModel.();
			return Json()*/
		}
	}
}
