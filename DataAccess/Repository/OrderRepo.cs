using DataAccess.Models;

namespace DataAccess.Repository;

public class OrderRepo : IOrderRepo
{
    public void AddOrder(Order order)
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteOrder(int id)
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            var order = dbContext.Orders.Find(id);
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public IEnumerable<Order> GetList()
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            return dbContext.Orders.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Order GetOrder(int id)
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            return dbContext.Orders.Find(id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void UpdateOrder(Order order)
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            dbContext.Entry<Order>(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
