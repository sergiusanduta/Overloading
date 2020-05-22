using System;
using System.Net.Http;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";


            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            Customer client = new Customer(5);
            Console.WriteLine(client.Id);

            Customer client2 = new Customer(16, "John");
            Console.WriteLine(client2.Name);

            var secondCustomer = new Customer();
            secondCustomer.Id = 2452;
            secondCustomer.Name = "Alex";
            
            var bycicleOrder = new Order();
            secondCustomer.Orders.Add(bycicleOrder);

        }

    }
}
