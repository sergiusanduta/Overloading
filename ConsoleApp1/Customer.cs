using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders = null;

        public Customer()
        {
            Orders = new List<Order>(); // Instantiate
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

          Customer(int id, string name)
            : this(id)
        {

            this.Name = name;
        }

        public Customer(Order order) : this()
        {
            Orders.Add(order);
        }

        public void AddOrder()
        {
            var order = new Order();
            Orders.Add(order);
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public void AddOrder(Order mar, Order mar2)
        {
            Orders.Add(mar);
            Orders.Add(mar2);
        }

    }

}
