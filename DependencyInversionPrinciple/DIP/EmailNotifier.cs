

using DependencyInversionPrinciple.BeforeDIP;

namespace DependencyInversionPrinciple.DIP
{
    public class EmailNotifier : ISend
    {
        public void Send(Order order)
        {
            Console.WriteLine($"Email sent to {order.CustomerEmail} for order {order.Id}");
        }
    }
}
