using DataAccess.Models;
using DataAccess.Repository;

namespace BusinessLayer;

public class OrderServices : IOrderServices
{
    public void AddOrder(Order order)
    {
        try
        {
            IOrderRepo orderRepo = new OrderRepo();
            orderRepo.AddOrder(order);
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
            IOrderRepo orderRepo = new OrderRepo();
            orderRepo.DeleteOrder(id);
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
            IOrderRepo orderRepo = new OrderRepo();
            return orderRepo.GetList();
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
            IOrderRepo orderRepo = new OrderRepo();
            return orderRepo.GetOrder(id);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public IEnumerable<Order> SearchByDate(DateTime begin, DateTime end)
    {
        if (begin > end)
        {
            var t = begin;
            begin = end;
            end = t;
        }
        try
        {
            IOrderRepo orderRepo = new OrderRepo();
            return from order in orderRepo.GetList()
                   where order.OrderDate >= begin && order.OrderDate <= end
                   select order;
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
            IOrderRepo orderRepo = new OrderRepo();
            orderRepo.UpdateOrder(order);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
