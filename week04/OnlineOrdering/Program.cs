using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address ("456 King St", "Toronto", "Ontario", "Canada");
        Customer customer1 = new Customer("John", address1);
        Customer customer2 = new Customer("Brock", address2);
        Product product1 = new Product ("Laptop", "P001", 999.99, 2);
        Product product2 = new Product ("Screen", "P002", 460.55, 5);
        Product product3 = new Product ("SmartPhone", "P003",250.00, 9);
        Product product4 = new Product ("Keyboard", "P004", 99.99, 4);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        System.Console.WriteLine(order1.GetPackingLabel());
        System.Console.WriteLine(order1.GetShippingLabel());
        System.Console.WriteLine(order1.GetTotalCost());
        System.Console.WriteLine(order2.GetPackingLabel());
        System.Console.WriteLine(order2.GetShippingLabel());
        System.Console.WriteLine(order2.GetTotalCost());
    }
}