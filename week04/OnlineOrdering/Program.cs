using System;
using System.Collections.Generic;

namespace OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple St", "Orem", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L101", 999.99f, 1));
        order1.AddProduct(new Product("Mouse", "M202", 25.50f, 2));

        Address address2 = new Address("456 Rue de Rivoli", "Paris", "IDF", "France");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P303", 699.00f, 1));
        order2.AddProduct(new Product("Case", "C404", 15.00f, 3));

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Order Cost: ${order.CalculateTotalPrice():0.00}");
            Console.WriteLine("------------------------------------------\n");
        }
    }
}