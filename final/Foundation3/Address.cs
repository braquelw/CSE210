using System;


public class Address
{
    private string _streetAddress { get; set; }
    private string _city { get; set; }
    private string _state { get; set; }
    private string _zipCode { get; set; }

    public Address(string streetAddress, string city, string state, string zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public string GetAddress()
    {
        string getAddress = $"{_streetAddress}\r\n{_city}, {_state} {_zipCode}";
        return getAddress;
    }
}