using System.Linq;

namespace GardenWeb.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _productContext;

        public ProductRepository(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public IQueryable<Product> GetProducts()
        {
            return _productContext.Products;
        }

        public IQueryable<Category> GetCategories()
        {
            return _productContext.Categories;
        }
    }
}