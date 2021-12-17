using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_GerenciadorDeConteudo.Controllers
{
    public class PaginasController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Paginas = new Pagina().Lista();
            return View();
        }
        public ActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public void Criar()
        {
            DateTime data;
            DateTime.TryParse(Request["data"], out data);
            var pagina = new Pagina();
            pagina.Nome = Request["nome"];
            pagina.Data = data;
            pagina.Conteudo = Request["conteudo"];
            pagina.Save();
            Response.Redirect("/paginas");
        }

        public ActionResult Conteudo(int id)
        {
            var pagina = Pagina.BuscarId(id);
            ViewBag.Pagina = pagina;
            return View();
        }

        public ActionResult Editar(int id)
        {
            var pagina = Pagina.BuscarId(id);
            ViewBag.Pagina = pagina;
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public void Alteracao(int id)
        {
            try
            {
                var pagina = Pagina.BuscarId(id);

                DateTime data;
                DateTime.TryParse(Request["data"], out data);

                pagina.Nome = Request["nome"];
                pagina.Data = data;
                pagina.Conteudo = Request["conteudo"];
                pagina.Save();

                TempData["sucesso"] = "Pagina alterada com sucesso";
            }
            catch (Exception error)   
            {
                TempData["erro"] = "Erro (" + error.Message + ")";

             //TempData["erro"] = "Ocorreu algum erro. A alteração não pôde ser concluida"; 

            }

            Response.Redirect("/paginas");
        }



        public void Excluir(int id)
        {
            Pagina.Excluir(id);
            Response.Redirect("/paginas");
        }



    }
}