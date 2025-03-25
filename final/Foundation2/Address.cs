class Address
{
    // Fields
    // private fields are used to store the street, city, state, and country of the address
    // The Address class is used to represent the address of the customer
    // The constructor takes a street, city, state, and country as parameters
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    // The constructor takes a street, city, state, and country as parameters
    // and initializes the private fields with these values
    // The Address class is used to represent the address of the customer
    // The constructor takes a street, city, state, and country as parameters
    // and initializes the private fields with these values
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Methods
    // these methods check if the address is in a specific country
    // The IsInUSA method checks if the address is in the USA
    // The IsInUSSR method checks if the address is in the USSR
    // The IsInUK method checks if the address is in the UK
    public bool IsInUSA() => _country == "USA";
    public bool IsInUSSR() => _country == "USSR";
    public bool IsInUK() => _country == "UK";
    

    // The GetAddress method returns the address of the customer
    // The Address class is used to represent the address of the customer
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}
