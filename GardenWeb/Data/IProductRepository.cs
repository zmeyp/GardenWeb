using System.Linq;

namespace GardenWeb.Data
{
    public interface IProductRepository
    {
        IQueryable<Product> GetProducts();
        IQueryable<Category> GetCategories();
    }
}