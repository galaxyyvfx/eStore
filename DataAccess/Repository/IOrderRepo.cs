using DataAccess.Models;

namespace DataAccess.Repository;

public interface IOrderRepo
{
    public Order GetOrder(int id);
    public IEnumerable<Order> GetList();
    public void AddOrder(Order order);
    public void UpdateOrder(Order order);
    public void DeleteOrder(int id);
}
