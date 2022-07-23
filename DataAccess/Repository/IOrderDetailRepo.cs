using DataAccess.Models;

namespace DataAccess.Repository;

public interface IOrderDetailRepo
{
    public OrderDetail GetOrderDetail(int orderId, int productId);
    public IEnumerable<OrderDetail> GetList();
    public void AddOrderDetail(OrderDetail orderDetail);
    public void UpdateOrderDetail(OrderDetail orderDetail);
    public void DeleteOrderDetail(int orderId, int productId);
}
