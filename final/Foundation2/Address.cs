class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public bool IsInUSSR()
    {
        return _country == "USSR";
    }

    public bool IsInUK()
    {
        return _country == "UK";
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}
