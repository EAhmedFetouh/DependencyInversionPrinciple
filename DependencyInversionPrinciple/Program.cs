
using DependencyInversionPrinciple.BeforeDIP;
using DependencyInversionPrinciple.DIP;



var order = new Order();
order.Total = 100;
order.CustomerEmail = "example@yahoo.com";
order.Id = 3;

var processor = new NewOrderProcessor(new  SqlOrderRepository(),new SmsNotifier());
processor.Process(order);




