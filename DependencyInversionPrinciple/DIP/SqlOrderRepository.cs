using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversionPrinciple.BeforeDIP;

namespace DependencyInversionPrinciple.DIP
{
    public class SqlOrderRepository: IOrderRepository
    {
        public void Save(Order order)
        {
            Console.WriteLine($"Order saved to SQL database. Order Id: {order.Id}, Total: {order.Total}");
        }
    }
}
