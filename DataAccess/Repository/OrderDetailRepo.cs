using DataAccess.Models;

namespace DataAccess.Repository;
public class OrderDetailRepo : IOrderDetailRepo
{
    public void AddOrderDetail(OrderDetail orderDetail)
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            dbContext.OrderDetails.Add(orderDetail);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteOrderDetail(int orderId, int productId)
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            var orderDetail = dbContext.OrderDetails.Find(new {orderId, productId});
            dbContext.OrderDetails.Remove(orderDetail);
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public IEnumerable<OrderDetail> GetList()
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            return dbContext.OrderDetails.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public OrderDetail GetOrderDetail(int orderId, int productId)
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            return dbContext.OrderDetails.Find(new {orderId, productId});
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void UpdateOrderDetail(OrderDetail orderDetail)
    {
        try
        {
            using var dbContext = new FStoreDBContext();
            dbContext.Entry<OrderDetail>(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
