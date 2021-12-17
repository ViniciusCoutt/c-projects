using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_GerenciadorDeConteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "sobre_vinicius_parametro",
                "sobre/{id}/vinicius", 
                new { controller = "Home", action = "about", id = 0 } // Para atribuir valor aos parâmetros
            );

            routes.MapRoute(
                "sobre",
                "sobre",
                new { controller = "Home", action = "about" }
            );

            routes.MapRoute(
                "paginas",
                "paginas", 
                new { controller = "Paginas", action = "Index" }
            );

            routes.MapRoute(
                "paginas_novo",
                "paginas/novo",
                new { controller = "Paginas", action = "Novo" }
            );

            routes.MapRoute(
                "paginas_criar",
                "paginas/criar",
                new { controller = "Paginas", action = "Criar" }
            );

            routes.MapRoute(
                "paginas_editar",
                "paginas/{id}/editar",
                new { controller = "Paginas", action = "Editar", id = 0 }
            );

            routes.MapRoute(
                "paginas_conteudo",
                "paginas/{id}/conteudo",
                new { controller = "Paginas", action = "Conteudo", id = 0 }
            );

            routes.MapRoute(
                "paginas_alterar",
                "paginas/{id}/alteracao",
                new { controller = "Paginas", action = "Alteracao", id = 0 }
            );

            routes.MapRoute(
                "paginas_excluir",
                "paginas/{id}/excluir",
                new { controller = "Paginas", action = "Excluir", id = 0 }
            );



            routes.MapRoute(
                "contato", // key que será buscada pelo action link no html
                "contato", // Oque aparecerá na url
                new { controller = "Home", action = "contact"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
