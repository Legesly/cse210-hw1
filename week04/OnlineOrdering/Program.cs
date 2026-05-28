using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A100", 899.99, 1));
        order1.AddProduct(new Product("Mouse", "B200", 25.50, 2));

        // Customer 2 (International)
        Address address2 = new Address("45 Oxford Road", "London", "London", "UK");
        Customer customer2 = new Customer("Sarah Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Camera", "C300", 499.99, 1));
        order2.AddProduct(new Product("Tripod", "D400", 75.00, 1));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine("----------------------------------------");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
        Console.WriteLine("----------------------------------------");
    }
}
