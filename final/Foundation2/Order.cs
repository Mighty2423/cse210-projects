class Order
{
    // Fields
    // private fields are used to store the products, customer, and order number
    // The Order class is used to represent an order in the order system
    // The constructor takes a customer as a parameter
    // and initializes the private fields with these values
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private int _orderNumber;

    // Constructor
    // The constructor takes a customer as a parameter
    // and initializes the private fields with these values
    // The Order class is used to represent an order in the order system
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Methods
    // The AddProduct method adds a product to the order
    // The product is added to the list of products in the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // The AddOrdernumber method sets the order number for the order
    // The order number is used to identify the order in the order system
    public void AddOrdernumber(int orderNumber)
    {
        _orderNumber = orderNumber;
    }

    // The GetCustomerName method returns the name of the customer
    // The customer name is used to represent the name of the customer in the order system
    public string GetCustomerName()
    {
        return _customer.GetName();
    }

    // The GetOrderNumber method returns the order number of the order
    // The order number is used to identify the order in the order system
    public int GetOrderNumber()
    {
        return _orderNumber;
    }

    // The GetOrderDetails method returns the details of the order
    // The order details include the names of the products in the order
    public string GetOrderDetails()
    {
        return string.Join(", ", _products.Select(p => p.GetName()));
    }

    // The GetTotalPrice method calculates the total price of the order
    // The total price is calculated by summing the prices of all products in the order
    public double GetTotalPrice()
    {
        return _products.Sum(p => p.GetTotalPrice());
    }

    // The GetCustomerAddress method returns the address of the customer
    // The customer address is used to represent the address of the customer in the order system
    public string GetCustomerAddress()
    {
        return _customer.GetAddress();
    }

    // The GetProducts method returns the list of products in the order
    // The products are used to represent the products in the order system
    public List<Product> GetProducts()
    {
        return _products;
    }

    // New method: Prints shipping label
    // The PrintShippingLabel method prints the shipping label for the order
    // The shipping label includes the customer name and address
    // The shipping label is used to identify the order in the shipping system
    // The shipping label is printed based on the address of the customer
    // The shipping label is printed based on the country of the address
    public void PrintShippingLabel()
    {
        // where the shipping label is printed based on the address of the customer
        // The shipping label is printed based on the country of the address
        Console.WriteLine("\n========================");
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
        Console.WriteLine("========================");
        
        // PrintShippingLabelDetails();
        // The PrintShippingLabelDetails method prints the shipping label details for the order
        // The shipping label details include the customer name and address
        // The shipping label details are used to identify the order in the shipping system
        // The shipping label details are printed based on the address of the customer
        Console.WriteLine("\n========================");
        Console.WriteLine("     SHIPPING LABEL");
        Console.WriteLine("========================");

        Console.WriteLine($"Customer Name: {GetCustomerName()}");
        Console.WriteLine($"Shipping Details: {GetCustomerAddress()}");
    }

    // New method: Prints order details
    public void PrintOrderDetails()
    {
        // The PrintOrderDetails method prints the order details for the order
        // The order details include the customer name, order number, and product details
        // The order details are used to identify the order in the order system
        // The order details are printed based on the address of the customer
        // The order details are printed based on the country of the address
        Console.WriteLine("\n========================");
        Console.WriteLine("      ORDER SHEET");
        Console.WriteLine("========================");
        Console.WriteLine($"Customer Name: {GetCustomerName()}");
        Console.WriteLine($"Order Number: {GetOrderNumber()}");
        Console.WriteLine("Order Details:");

        // The foreach loop iterates through the list of products in the order
        // The foreach loop is used to print the details of each product in the order
        foreach (var product in _products)
        {
            Console.WriteLine($"- {product.GetProductsName()} (ID: {product.GetProductID()}) | Price: {product.GetPrice()} {product.GetCurrencyType()} | Quantity: {product.GetQuantity()} | Total: {product.GetTotalPrice()} {product.GetCurrencyType()}");
        }

        // The foreach loop is used to print the total price of the order
        // The foreach loop iterates through the list of products in the order
        Console.WriteLine($"\nTotal Order Cost: {GetTotalPrice()} {_products[0].GetCurrencyType()}\n");
    }
}
