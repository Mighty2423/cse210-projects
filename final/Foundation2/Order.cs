class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    private int _orderNumber;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void AddOrdernumber(int orderNumber)
    {
        _orderNumber = orderNumber;
    }

    public string GetCustomerName()
    {
        return _customer.GetName();
    }

    public int GetOrderNumber()
    {
        return _orderNumber;
    }

    public string GetOrderDetails()
    {
        return string.Join(", ", _products.Select(p => p.GetName()));
    }

    public double GetTotalPrice()
    {
        return _products.Sum(p => p.GetTotalPrice());
    }

    public string GetCustomerAddress()
    {
        return _customer.GetAddress();
    }

    public List<Product> GetProducts()
    {
        return _products;
    }


    // New method: Prints shipping label
    public void PrintShippingLabel()
    {
        if (_customer.GetAddress().Contains("USA"))
        {
            Console.WriteLine("Shipping to USA");
        }
        else if (_customer.GetAddress().Contains("UK"))
        {
            Console.WriteLine("Shipping to UK");
        }
        else if (_customer.GetAddress().Contains("USSR"))
        {
            Console.WriteLine("Shipping to USSR");
        }
        else
        {
            Console.WriteLine("Invalid Address");
        }
        Console.WriteLine("\n========================");
        Console.WriteLine("     SHIPPING LABEL");
        Console.WriteLine("========================");

        Console.WriteLine($"Customer Name: {GetCustomerName()}");
        Console.WriteLine($"Shipping Details: {GetCustomerAddress()}");
    }

    // New method: Prints order details
    public void PrintOrderDetails()
    {
        Console.WriteLine("\n========================");
        Console.WriteLine("      ORDER SHEET");
        Console.WriteLine("========================");
        Console.WriteLine($"Customer Name: {GetCustomerName()}");
        Console.WriteLine($"Order Number: {GetOrderNumber()}");
        Console.WriteLine("Order Details:");

        foreach (var product in _products)
        {
            Console.WriteLine($"- {product.GetProductsName()} (ID: {product.GetProductID()}) | Price: {product.GetPrice()} {product.GetCurrencyType()} | Quantity: {product.GetQuantity()} | Total: {product.GetTotalPrice()} {product.GetCurrencyType()}");
        }

        Console.WriteLine($"\nTotal Order Cost: {GetTotalPrice()} {_products[0].GetCurrencyType()}\n");
    }
}