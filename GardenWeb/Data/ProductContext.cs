using System.Data.Entity;

namespace GardenWeb.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            :base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductContext, ProductsMigrationConfiguration>());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}