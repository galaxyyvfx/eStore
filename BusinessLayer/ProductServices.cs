using DataAccess.Models;
using DataAccess.Repository;

namespace BusinessLayer;

public class ProductServices : IProductServices
{
    public void AddProduct(Product product)
    {
        try
        {
            IProductRepo productRepo = new ProductRepo();
            productRepo.AddProduct(product);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteProduct(int id)
    {
        try
        {
            IProductRepo productRepo = new ProductRepo();
            productRepo.DeleteProduct(id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public IEnumerable<Product> GetList()
    {
        try
        {
            IProductRepo productRepo = new ProductRepo();
            return productRepo.GetList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Product GetProduct(int id)
    {
        try
        {
            IProductRepo productRepo = new ProductRepo();
            return productRepo.GetProduct(id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public IEnumerable<Product> SearchByName(string name)
    {
        try
        {
            IProductRepo productRepo = new ProductRepo();
            return from product in productRepo.GetList()
                   where (product.ProductName.Contains(name))
                   select product;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public IEnumerable<Product> SearchByPrice(decimal min, decimal max)
    {
        try
        {
            IProductRepo productRepo = new ProductRepo();
            return from product in productRepo.GetList()
                   where product.UnitPrice >= min && product.UnitPrice <= max
                   select product;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void UpdateProduct(Product product)
    {
        try
        {
            IProductRepo productRepo = new ProductRepo();
            productRepo.UpdateProduct(product);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
