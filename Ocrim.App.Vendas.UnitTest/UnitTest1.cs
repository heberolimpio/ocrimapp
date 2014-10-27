using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ocrim.App.Vendas.UnitTest
{
    [TestClass]
    public class UnitTestOcrim
    {
        [TestMethod]
        public void Take()
        {
            //O operador Take eh usado para selecionar os primeiros n objetos de uma colecao.

            int[] numeros = { 5, 4, 1, 3, 9, 8, 7, 6, 7, 2, 0 };
            var resultado = from num in numeros.Take(5) select num;
            int[] teste = { 5, 4, 1, 3, 9 };
            CollectionAssert.AreEqual(resultado.ToArray(), teste);


        }


        [TestMethod]
        public void Skip()
        {
            //O operador Skip ignora o(s) primeiro(s) n objetos de uma colecao.

            int[] numeros = { 5, 4, 1, 3, 9, 8, 7, 6, 7, 2, 0 };
            var resultado = from num in numeros.Take(5).Skip(2) select num;
            int[] teste = { 1, 3, 9 };
            CollectionAssert.AreEqual(resultado.ToArray(), teste);


        }
    }



}
