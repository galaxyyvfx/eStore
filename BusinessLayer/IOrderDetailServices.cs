using DataAccess.Models;

namespace BusinessLayer;

public interface IOrderDetailServices
{
    public OrderDetail GetOrderDetail(int orderId, int productId);
    public IEnumerable<OrderDetail> GetList();
    public void AddOrderDetail(Order orderDetail);
    public void UpdateOrderDetail(Order orderDetail);
    public void DeleteOrderDetail(int orderId, int productId);
}
