using Microsoft.EntityFrameworkCore;
using products.Domain.Base.Categories;
using products.Domain.Base.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace products.Infrustructure
{
    public class ProductDBContext:DbContext
    {
        public ProductDBContext(DbContextOptions options):base (options)    
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new Category.CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new Product.ProductConfiguration());


        }
    }

   
}
