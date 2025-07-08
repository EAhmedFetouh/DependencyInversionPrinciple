using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversionPrinciple.BeforeDIP;

namespace DependencyInversionPrinciple.DIP
{
    public class NewOrderProcessor
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ISend _notifier;

        public NewOrderProcessor(IOrderRepository orderRepository, ISend notifier)
        {
            _orderRepository = orderRepository;
            _notifier = notifier;
        }


        public void Process(Order order)
        {
            order.Total = 100; 
            _orderRepository.Save(order);
            _notifier.Send(order);
            Console.WriteLine("Order processed (DIP version).");
        }
    }
}
