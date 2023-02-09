using System;


public class Product
{
    private string _productName { get; set; }
    private string _productID { get; set; }
    private double _productPrice { get; set; }
    private int _productQuantity { get; set; }

    public Product(string productName, string productID, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }
    public double GetSubTotal()
    {
        double subtotal = _productPrice * _productQuantity;
        return subtotal;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{_productName} ({_productID}) - Total: ${Math.Round(_productPrice * _productQuantity, 2)}");
    }
}