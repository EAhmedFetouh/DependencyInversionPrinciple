

using DependencyInversionPrinciple.BeforeDIP;

namespace DependencyInversionPrinciple.DIP
{
    public class SmsNotifier : ISend
    {
        public void Send(Order order)
        {
            Console.WriteLine($"SMS sent to {02222222222} for order {order.Id}");
        }
    }
}
