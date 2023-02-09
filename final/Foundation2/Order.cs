using System;


public class Order
{
    public List<Product> _products = new List<Product>();
    public string _customer { get; set; }
    public double _shippingCost { get; set; }

    public double GetSubtotalPrice()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            double subtotal = product.GetSubTotal();
            total += subtotal;
        }
        total = Math.Round(total, 2);
        return total;
    }
    public double GetTotalPrice()
    {
        double total = (GetSubtotalPrice() + _shippingCost);
        total = Math.Round(total, 2);
        return total;
    }

    public void DisplayTotalPrice()
    {
        Console.WriteLine($"Total Price: ${(GetTotalPrice())}");
    }

    public void GetShippingLabel()
    {
        Console.WriteLine("SHIP TO:");
        Console.WriteLine($"{_customer}");
    }

    public void GetPackingLabel()
    {
        Console.WriteLine($"{_customer}");
        Console.WriteLine();
        foreach (Product product in _products)
        {
            product.DisplayProduct();
        }
        Console.WriteLine();
        Console.WriteLine($"Subtotal: ${GetSubtotalPrice()}");
        Console.WriteLine($"Shipping: ${_shippingCost}");
        Console.WriteLine($"Total: ${GetTotalPrice()}");
    }
}