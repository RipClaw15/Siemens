using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{
    public int OrderId { get; set; }
    public Customer Customer { get; set; }
    public int CustomerId { get; set; }
    public string DeliveryAddress { get; set; }
    
    public DateTime OrderDate { get; set; }
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();


    // Methods
    public Order()
    {
        OrderDate = DateTime.Now;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public decimal CalculateFinalPrice()
    {
        decimal subtotal = 0;
        foreach (OrderItem item in Items)
        {
            subtotal += item.Quantity * item.UnitPrice;
        }

        if (subtotal > 500)
        {
            return subtotal * 0.9m;
        }
        return subtotal;
    }

}
