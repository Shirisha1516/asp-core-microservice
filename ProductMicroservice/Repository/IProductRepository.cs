using ProductMicroservice.Models;

namespace ProductMicroservice.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductByID(int productId);

        int InsertProduct(Product product);

        void DeleteProduct(int productId);

        void UpdateProduct(Product product);

        void Save();
    }
}
