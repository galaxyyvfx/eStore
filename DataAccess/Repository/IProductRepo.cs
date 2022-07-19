using DataAccess.Models;

namespace DataAccess.Repository;

public interface IProductRepo
{
    public Product GetProduct(int id);
    public IEnumerable<Product> GetList();
    public void AddProduct(Product product);
    public void UpdateProduct(Product product);
    public void DeleteProduct(int id);
}
