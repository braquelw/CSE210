using System;


public class Customer
{
    private string _customerName { get; set; }
    private string _customerAddress { get; set; }
    private string _customerCountry { get; set; }

    public Customer (string customerName, string customerAddress, string customerCountry)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
        _customerCountry = customerCountry;
    }

    public double GetShippingCost()
    {
        double shippingCost = 0;
        if (_customerCountry == "USA")
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }

    public string DisplayCustomer()
    {
        return $"{_customerName}\r\n{_customerAddress}";
    }
}