using DataAccess.Models;

namespace BusinessLayer;

public class ProductServices : IProductServices
{
    public void AddProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public void DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetList()
    {
        throw new NotImplementedException();
    }

    public Product GetProduct(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> SearchByName(string name)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> SearchByPrice(decimal min, decimal max)
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}
