
class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private string _currentcytype;
    private int _quantity;

    public Product(string name, int productID, double price, int quantity, string currentcytype)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
        _currentcytype = currentcytype;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public string GetCurrencyType()
    {
        if (_currentcytype == "USD")
        {
            return "USD";
        }
        else if (_currentcytype == "GBP")
        {
            return "GBP";
        }
        else if (_currentcytype == "RUB")
        {
            return "RUB";
        }
        else
        {
            return "Invalid Currency";
        }
    }

    public string GetProductsName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    public int GetProductDetails()
    {
        return _quantity;
    }

    public string GetName()
    {
        return _name;
    }
}