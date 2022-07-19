using DataAccess.Models;

namespace BusinessLayer;

public interface IProductServices
{
    public Product GetProduct(int id);
    public IEnumerable<Product> GetList();
    public IEnumerable<Product> SearchByName(string name);
    public IEnumerable<Product> SearchByPrice(decimal min, decimal max);
    public void AddProduct(Product product);
    public void UpdateProduct(Product product);
    public void DeleteProduct(int id);
}
