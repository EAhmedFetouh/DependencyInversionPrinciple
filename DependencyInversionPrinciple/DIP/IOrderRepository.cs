

using DependencyInversionPrinciple.BeforeDIP;

namespace DependencyInversionPrinciple.DIP;

public interface IOrderRepository
{
    void Save(Order order);
}
