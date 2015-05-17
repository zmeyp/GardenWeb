using System;
using System.Data.Entity.Migrations;
using System.Data.SqlTypes;
using System.Linq;

namespace GardenWeb.Data
{
    public class ProductsMigrationConfiguration : DbMigrationsConfiguration<ProductContext>
    {
        public ProductsMigrationConfiguration()
        {
            // TODO: remove before publishing
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProductContext context)
        {
            base.Seed(context);

#if DEBUG
            if (!context.Categories.Any())
            {
                var category = new Category
                {
                    Title = "Category 1",
                    Description = "Category 1 Description",
                };
                context.Categories.Add(category);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }


#endif
        }
    }
}