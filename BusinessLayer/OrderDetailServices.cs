using DataAccess.Models;
using DataAccess.Repository;

namespace BusinessLayer;
public class OrderDetailServices : IOrderDetailServices
{
    public void AddOrderDetail(Order orderDetail)
    {
        try
        {
            IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
            orderDetailRepo.AddOrderDetail(orderDetail);
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
            IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
            orderDetailRepo.DeleteOrderDetail(orderId, productId);
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
            IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
            return orderDetailRepo.GetList();
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
            IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
            return orderDetailRepo.GetOrderDetail(orderId, productId);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void UpdateOrderDetail(Order orderDetail)
    {
        try
        {
            IOrderDetailRepo orderDetailRepo = new OrderDetailRepo();
            orderDetailRepo.UpdateOrderDetail(orderDetail);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
