using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Product Ordering System Simulation ---\n");

        //a few orders to test the program
        Console.WriteLine("order number 1");
        Address address1 = new Address("1215 main street", "san fransisco", "CA", "USA");
        Customer customer1 = new Customer("Brittney Benson", address1);
        Order order1 = new Order(customer1);

        order1.NewProduct(new Product("Mouse Pad", "FW363", 11.00m, 1));
        order1.NewProduct(new Product("screen protector", "HS-500", 25.50m, 2));
        order1.NewProduct(new Product("Keyboard Cover", "LM-101", 10.00m, 1));

        Console.WriteLine("\n" + order1.NewPackingLabel());
        Console.WriteLine("\n" + order1.NewShippingLabel());
        Console.WriteLine($"Today's total: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine("Order number 2");
        Address address2 = new Address("45 international ave", "mexico city", "mexico city", "mexico");
        Customer customer2 = new Customer("maria farrera", address2);
        Order order2 = new Order(customer2);

        order2.NewProduct(new Product("Laptop", "FS-800", 1150.00m, 1));
        order2.NewProduct(new Product("Protective Case", "BD-124", 15.99m, 1));

        Console.WriteLine("\n" + order2.NewPackingLabel());
        Console.WriteLine("\n" + order2.NewShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotalCost():F2}\n");

        Console.WriteLine("Order number 3");
        Address address3 = new Address("160 N 18th Ave", "Idaho Falls", "ID", "USA");
        Customer customer3 = new Customer("George Strait", address3);
        Order order3 = new Order(customer3);

        order3.NewProduct(new Product("Guitar", "G-451", 475.99m, 1));
        order3.NewProduct(new Product("Amplifier", "Lc235", 112.99m, 1));
        order3.NewProduct(new Product("Streaming Camera", "Bg-1248", 249.99m, 1));

        Console.WriteLine("\n" + order3.NewPackingLabel());
        Console.WriteLine("\n" + order3.NewShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order3.CalculateTotalCost():F2}\n");
        //exit the program
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}