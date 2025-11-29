using System;

class Program
{
    static void Main(string[] args)
    {
       
        Address addr1 = new Address("123 Maple St", "Dallas", "TX", "USA");
        Customer cust1 = new Customer("Andrew Nafagha", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop Stand", "LS01", 25.99, 2));
        order1.AddProduct(new Product("Wireless Mouse", "WM08", 15.50, 1));

        Address addr2 = new Address("55 Victoria Road", "London", "London", "UK");
        Customer cust2 = new Customer("James Walker", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("USB-C Cable", "CB21", 10.00, 3));
        order2.AddProduct(new Product("Portable Charger", "PC77", 35.00, 1));

        Console.WriteLine("=============================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
    
        Console.WriteLine("\n=============================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
