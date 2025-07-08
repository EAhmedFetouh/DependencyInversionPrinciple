

using DependencyInversionPrinciple.BeforeDIP;

namespace DependencyInversionPrinciple.DIP
{
    public class MySqlOrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
            Console.WriteLine($"Order saved to MySql database. Order Id: {order.Id}, Total: {order.Total}");
        }
    }
}
