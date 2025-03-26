class Address
{
    // Fields to store address components
    // These fields are private to encapsulate the data
    // and ensure they are only modified through methods of this class.
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Properties to expose the fields with public getters
    // and private setters to maintain encapsulation.
    public Address(string street, string city, string state, string country)
    {
        // Constructor to initialize the address components
        // This constructor is public to allow instantiation of the class
        // with the required parameters.
        // The parameters are assigned to the private fields.
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Property to get the Address as a string
    // This property is public to allow access to the full address
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}

