
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

    public string GetProductsName()
    {
        return _name;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public string GetCurrencyType()
    {
        return _currentcytype;
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

}