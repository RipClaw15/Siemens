using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string DefaultShippingAdress { get; set; }

    public List<Order> Orders { get; set; } = new List<Order>();

    public void AddOrder(Order order)
    {
        order.CustomerId = this.CustomerId;
        order.Customer = this;
        Orders.Add(order);
    }

    // Methods

    public decimal TotalSpent()
    {
        return Orders.Sum(order => order.CalculateFinalPrice());
        
    }

}