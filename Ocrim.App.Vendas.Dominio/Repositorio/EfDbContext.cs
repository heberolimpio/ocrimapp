using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocrim.App.Vendas.Dominio.Entidades;
	

namespace Ocrim.App.Vendas.Dominio.Repositorio
{
    public class EfDbContext : DbContext

    {
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) //evita a plurarizacao produto produtos
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");

        }

    }
}
