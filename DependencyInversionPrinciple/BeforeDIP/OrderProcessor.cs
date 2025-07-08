
namespace DependencyInversionPrinciple.BeforeDIP;

//public class OrderProcessor
//{
//    private readonly MySqlOrderRepository _orderRepository;
//    private readonly EmailNotifier _notifier;

//    public OrderProcessor()
//    {

//        _orderRepository = new MySqlOrderRepository();
//        _notifier = new EmailNotifier();
//    }

//    public void Process(Order order)
//    {
//         order.Total = 100;
//        _orderRepository.Save(order);
//        _notifier.NotifyCustomer(order);
//        Console.WriteLine("Order processed (bad version).");
//    }
//}

