using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    // Create address and customer
    // Create customers with their addresses
    // The Address class is used to represent the address of the customer
    // The Customer class is used to represent the customer
    // The constructor takes a name and an address as parameters
    Address address1 = new Address("123 Elm St", "New York", "NY", "USA");
    Customer customer1 = new Customer("John Doe", address1);

    Address address2 = new Address("12 Baker Street", "London", "London", "UK");
    Customer customer2 = new Customer("John Clements", address2);

    Address address3 = new Address("12 Lenin Street", "Moscow", "Moscow", "USSR");
    Customer customer3 = new Customer("Ivan Ivanov", address3);

    // Create products
    // The Product class is used to represent a product in the order system
    // The constructor takes a name, product ID, price, quantity, and currency type as parameters
    // The currency type is used to represent the currency in which the product is priced
    Product product1 = new Product("Laptop", 101, 999.99, 1, "USD");
    Product product2 = new Product("Mouse", 102, 49.99, 2, "USD");

    Product product3 = new Product("Wine", 103, 99.99, 1, "GBP");
    Product product4 = new Product("Tea", 60, 1.99, 2, "GBP");

    Product product5 = new Product("Vodka", 104, 99.99, 1, "RUB");
    Product product6 = new Product("Caviar", 105, 199.99, 2, "RUB");

    // create product prices
    // The GetTotalPrice method calculates the total price of the product
    // The total price is calculated by multiplying the price of the product by its quantity
    // The GetTotalPrice method returns the total price of the product
    // The total price is used to represent the total price of the product in the order system
    // The total price is calculated by summing the prices of all products in the order
    double total1 = product1.GetTotalPrice() + product2.GetTotalPrice();
    double total2 = product3.GetTotalPrice() + product4.GetTotalPrice();
    double total3 = product5.GetTotalPrice() + product6.GetTotalPrice();

    // Create orders
    // The Order class is used to represent an order in the order system
    // The constructor takes a customer as a parameter
    Order order1 = new Order(customer1);
    order1.AddProduct(product1);
    order1.AddProduct(product2);
    order1.AddOrdernumber(1);

    Order order2 = new Order(customer2);
    order2.AddProduct(product3);
    order2.AddProduct(product4);
    order2.AddOrdernumber(2);

    Order order3 = new Order(customer3);
    order3.AddProduct(product5);
    order3.AddProduct(product6);
    order3.AddOrdernumber(3);

    // Create a list of orders
    // The List class is used to represent a list of orders in the order system
    // The List class is used to represent a list of products in the order system
    List<Order> orders = new List<Order> { order1, order2, order3 };

    // Print order details using the extracted methods
    // PrintOrderDetails(orders);
    // PrintShippingLabel(orders);
    // Print order details and shipping labels for each order
    foreach (var order in orders)
    {
      order.PrintShippingLabel();
      order.PrintOrderDetails();
    }
  }
}







