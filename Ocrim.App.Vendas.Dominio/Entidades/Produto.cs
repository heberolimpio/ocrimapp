using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocrim.App.Vendas.Dominio.Entidades
{
    class Produto //classe para cuidar dos produtos
    {
        
        //propriendades da classe produto

        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public string Categoria { get; set; }
    }
}
