
// need to fix all noformated and comments in the code
class Customer
{
    // Fields
    // private fields are used to store the name and address of the customer
    private string _name;
    // private fields are used to store the address of the customer
    // The Address class is used to represent the address of the customer
    private Address _address;

    // Constructor
    // The constructor takes a name and an address as parameters
    // and initializes the private fields with these values
    // The Address class is used to represent the address of the customer
    public Customer(string name, Address address)
    {
        // The constructor takes a name and an address as parameters
        // and initializes the private fields with these values
        _name = name;
        // The Address class is used to represent the address of the customer
        // The constructor takes a name and an address as parameters
        _address = address;
    }

    // Methods
    // The GetName method returns the name of the customer
    public string GetName()
    {
        return _name;
    }

    // The GetAddress method returns the address of the customer
    // The Address class is used to represent the address of the customer
    public string GetAddress()
    {
        return _address.GetAddress();
    }
}
