class Product
{
    // Private fields
    // The Product class is used to represent a product in the order system.
    // The constructor takes a name, product ID, price, quantity, and currency type as parameters.
    // The private fields are used to store the name, product ID, price, quantity, and currency type of the product.
    private string _name;
    private int _productID;
    private double _price;
    private string _currencyType;
    private int _quantity;

    // Constructor
    // The constructor takes a name, product ID, price, quantity, and currency type as parameters.
    // It initializes the private fields with these values.
    // The Product class is used to represent a product in the order system.
    // The constructor takes a name, product ID, price, quantity, and currency type as parameters.
    public Product(string name, int productID, double price, int quantity, string currencyType)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
        _currencyType = currencyType;
    }

    // Methods
    // The GetProductID method returns the product ID of the product.
    public int GetProductID()
    {
        return _productID;
    }

    // The GetCurrencyType method returns the currency type of the product.
    // The currency type is used to represent the currency in which the product is priced.
    public string GetCurrencyType()
    {
        // the currency type is used to represent the currency in which the product is priced
        // by checking the value of _currencyType, we can determine the currency type of the product

        if (_currencyType == "USD")
        {
            return "USD";
        }
        else if (_currencyType == "GBP")
        {
            return "GBP";
        }
        else if (_currencyType == "RUB")
        {
            return "RUB";
        }
        else
        {
            return "Invalid Currency";
        }
    }

    // The GetProductsName method returns the name of the product.
    // The name of the product is used to represent the name of the product in the order system.
    public string GetProductsName()
    {
        return _name;
    }

    // The GetPrice method returns the price of the product.
    // The price of the product is used to represent the price of the product in the order system.
    public double GetPrice()
    {
        return _price;
    }

    // The GetQuantity method returns the quantity of the product.
    // The quantity of the product is used to represent the quantity of the product in the order system.
    public int GetQuantity()
    {
        return _quantity;
    }

    // The GetTotalPrice method returns the total price of the product.
    // The total price of the product is calculated by multiplying the price and quantity of the product.
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    // The GetName method returns the name of the product.
    // The name of the product is used to represent the name of the product in the order system.
    public string GetName()
    {
        return _name;
    }
}
