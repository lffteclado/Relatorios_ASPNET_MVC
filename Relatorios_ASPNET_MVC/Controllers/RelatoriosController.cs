using PagedList;
using Relatorios_ASPNET_MVC.Models;
using Rotativa;
using Rotativa.Options;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Relatorios_ASPNET_MVC.Controllers
{
    public class RelatoriosController : Controller
    {
        private VendaRelatorioDbContext _db = new VendaRelatorioDbContext();

        // GET: Relatorios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListagemClientes(int? pagina, Boolean? gerarPDF)
        {
            var listagemClientes = _db.Clientes.OrderBy(n => n.ClienteId).ToList<Cliente>();

            if(gerarPDF != true)
            {
                //Definindo a paginação
                int paginaQtdeRegistros = 10;
                int paginaNumeroNavegação = (pagina ?? 1);

                return View(listagemClientes.ToPagedList(paginaNumeroNavegação, paginaQtdeRegistros));
            }
            else
            {
                int paginaNumero = 1;

                var pdf = new ViewAsPdf
                {
                    ViewName = "ListagemClientes",
                    PageSize = Size.A4,
                    IsGrayScale = true,
                    Model = listagemClientes.ToPagedList(paginaNumero, listagemClientes.Count)
                };

                return pdf;
            }
        }
    }
}