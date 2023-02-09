using System;


public class Address
{
    private string _streetAddress { get; set; }
    private string _city { get; set; }
    private string _state { get; set; }
    private string _zipCode { get; set; }
    private string _country { get; set; }

    public Address(string streetAddress, string city, string state, string zipCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetAddress()
    {
        string getAddress = $"{_streetAddress}\r\n{_city}, {_state} {_zipCode}\r\n{_country}";
        return getAddress;
    }
}