using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.BeforeDIP
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerEmail { get; set; }
        public decimal Total { get; set; }
    }
}
