using DataAccess.Models;

namespace DataAccess.Repository;

public class ProductRepo : IProductRepo
{
    public void AddProduct(Product product)
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
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
            using var dbContext = new FStoreDBContext();
            var product = dbContext.Products.Find(id);
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
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
            using var dbContext = new FStoreDBContext();
            return dbContext.Products.ToList();
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
            using var dbContext = new FStoreDBContext();
            return dbContext.Products.Find(id);
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
            using var dbContext = new FStoreDBContext();
            dbContext.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
