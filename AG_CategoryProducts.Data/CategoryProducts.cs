using AG_CategoryProducts.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AG_CategoryProducts.Data
{
    public class CategoryProducts : DbContext
    {
        public DbSet<producto> Productos { get; set; }
        public DbSet<categoria> Categoria { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=dbproductos;Trusted_Connection=True;");
        }
        

    }
}
