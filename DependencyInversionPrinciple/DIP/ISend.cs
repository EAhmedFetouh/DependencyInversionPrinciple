using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInversionPrinciple.BeforeDIP;

namespace DependencyInversionPrinciple.DIP
{
    public interface ISend
    {
        void Send(Order order);
    }
}
