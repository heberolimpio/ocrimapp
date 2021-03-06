﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ocrim.App.Vendas.Dominio.Repositorio;

namespace Ocrim.App.Vendas.Web.Controllers
{
    public class VitrineController : Controller
    {

        private ProdutosRepositorio _repositorio;
        // GET: Vitrine
        public int ProdutosPorPagina = 3;
        public ActionResult ListaProdutos(int pagina = 1)
        {

            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina);
            




            return View(produtos);
        }
    }
}