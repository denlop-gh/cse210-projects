using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressUSA = new Address("123 Main St", "Springfield", "IL", "62701");
        Address addressGuatemala = new Address("456 Elm St", "Guatemala City", "Guatemala", "01001");

        Customer customer1 = new Customer("John Doe", addressUSA);
        Customer customer2 = new Customer("Dennis Lopez", addressGuatemala);

        Product product1 = new Product("Laptop", "P001", 999.99m, 1);
        Product product2 = new Product("Smartphone", "P002", 499.99m, 2);
        Product product3 = new Product("Headphones", "P003", 199.99m, 3);
        Product product4 = new Product("Tablet", "P004", 299.99m, 1);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.GetTotalPrice():C}\n");

        Console.WriteLine("Order 2 Details:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.GetTotalPrice():C}\n");
              
    }
}