using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ocrim.App.Vendas.Dominio.Repositorio;

namespace Ocrim.App.Vendas.Web.Controllers
{
    public class ProdutosController : Controller
    {

        private ProdutosRepositorio _repositorio;
        //
        // GET: Produtos
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.Take(10);//como um top 10, quantos vai retornar.

            return View(produtos);
        }
    }
}