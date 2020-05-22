using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer(1, "John");
            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);

            Order myFirstOrder = new Order();
            Customer cs1 = new Customer(myFirstOrder);
            cs1.AddOrder();

            Order mySecondOrder = new Order();
            cs1.AddOrder(mySecondOrder);

            //Order mar1 = new Order();
            //Order mar2 = new Order();
            //cs1.AddOrder(mar1, mar2);
            Console.WriteLine(cs1.Orders.Count);
        }
    }
}
