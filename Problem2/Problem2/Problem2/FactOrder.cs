using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FactOrder
{
    public static string FindTopSpender(List<Customer> listCustomers)
    {
        if (listCustomers == null || listCustomers.Count == 0) return null;

        Customer topCustomer = null;
        decimal max = 0;
        foreach (Customer customer in listCustomers)
        {
            decimal total = customer.TotalSpent();
            if (total > max)
            {
                max = total;
                topCustomer = customer;
            }
        }
        return topCustomer.Name;
    }

    public static Dictionary<string, int> GetPopularProducts(List<Customer> listCustomers) {
        Dictionary<string, int> result = new Dictionary<string, int>();
        foreach (var customer in listCustomers) 
        {
            foreach (var order in customer.Orders)
            {
                foreach (var item in order.Items)
                    if (result.ContainsKey(item.ProductName))
                    {
                        result[item.ProductName] += item.Quantity;
                    }
                    else
                    {
                        result[item.ProductName ] = item.Quantity;
                    }
            }
        }
        return result;
    } 
    
}


