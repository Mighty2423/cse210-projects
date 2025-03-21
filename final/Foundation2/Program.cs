using System;

class Program
{
    static void Main(string[] args)
    {
      // Create address and customer
        Address address1 = new Address("123 Elm St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("12 Baker Street","London", "London", "UK");
        Customer customer2 = new Customer("John Clements", address2);

        Address address3 = new Address("12 Lenin Street", "Moscow", "Moscow", "USSR");
        Customer customer3 = new Customer("Ivan Ivanov", address3);

        // Create products
        Product product1 = new Product("Laptop", 101, 999.99, 1, "USD");
        Product product2 = new Product("Mouse", 102, 49.99, 2, "USD");

        Product product3 = new Product("Wine", 103, 99.99, 1, "GBP");
        Product product4 = new Product("Tea", 60, 1.99, 2, "GBP");

        Product product5 = new Product("Vodka", 104, 99.99, 1, "RUB");
        Product product6 = new Product("Caviar", 105, 199.99, 2, "RUB");

        // create product prices
    }
}