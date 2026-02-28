using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        Console.WriteLine("Main Program");
        // Create example order with items
        Customer customer1 = new Customer { CustomerId = 1 , Name = "Csongor Osz", Email = "csongorosz@gmail.com"};
        Customer customer2 = new Customer { CustomerId = 2, Name = "Gyorgy Osz", Email = "csongor1551@gmail.com" };

        Order order1 = new Order
        {
            OrderId = 1000,
            Customer = customer1,
            CustomerId = customer1.CustomerId,
            DeliveryAddress = "Str. Braz, Nr.27"
        };

        order1.AddItem(new OrderItem("Macbook Air", 1, 3499.90m));
        order1.AddItem(new OrderItem("Tablet Lenovo", 1, 1799.90m));

        Order order2 = new Order
        {
            OrderId = 1001,
            Customer = customer1,
            CustomerId = customer1.CustomerId,
            DeliveryAddress = "Str. Braz, Nr.27"
        };

        order2.AddItem(new OrderItem("Iphone 15 Pro Max", 1, 5499.90m));
        
        customer1.AddOrder(order1);
        customer1.AddOrder(order2);

        Order order3 = new Order
        {
            OrderId = 1003,
            Customer = customer2,
            CustomerId = customer2.CustomerId,
            DeliveryAddress = "Work"
        };

        order3.AddItem(new OrderItem("Earpods", 1, 799.90m));
        order3.AddItem(new OrderItem("Macbook Air", 1, 3499.90m));

        customer2.AddOrder(order3);

        Console.WriteLine(order1.CalculateFinalPrice());
        Console.WriteLine(order1.Customer.Name);
        Console.WriteLine(order2.CalculateFinalPrice());
        Console.WriteLine(customer1.TotalSpent());

        List<Customer> customers = new List<Customer> { customer1, customer2 };

        string topSpender = FactOrder.FindTopSpender(customers);
        var popularItems = FactOrder.GetPopularProducts(customers);
        Console.WriteLine(topSpender);
        foreach ( var product in popularItems )
        { Console.WriteLine($"{product.Key} {product.Value}"); }
        
    }
}