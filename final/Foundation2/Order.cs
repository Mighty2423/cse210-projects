class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    private int _ordernumber;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void AddOrdernumber(int ordernumber)
    {
        _ordernumber = ordernumber;
    }


}
