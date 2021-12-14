using LazyLoadingTask.Models;
using Microsoft.EntityFrameworkCore;

namespace LazyLoadingTask.Context
{
    public class MyDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=RAIDER\SQLEXPRESS;Initial Catalog=LazyDb;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
            
        }
    }
    
    
}