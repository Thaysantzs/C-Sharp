using System;

namespace OurStore;


public class OurStoreApp
{
    public static void Main(string[] args)
    {
        Customer? customer = new Customer(
            "thiago.santiago@gmail.com", "Thiago Santiago", 
            "200 Street 2, San Diego, CA, 876683"
        );

        Customers? customers = new();
        customers.Add(customer);

        Customer customer1 = customers.Add(
            "Flavio.machado@gmail.com", "Flavio Machado",
            "200 Street 2, San Diego, CA, 876683"
        );

        Console.WriteLine(customer);
        Console.WriteLine(customer1);

        Customer? Find1 = customers.FindByEmail("thiago.santiago@gmail.com");
        Customer? Find2 = customers.FindByEmail("Flavio.machado@gmail.com");
        Customer? Find3 = customers.FindByEmail("Maria.arruda@gmail.com");

        Console.WriteLine(Find1);
        Console.WriteLine(Find2);
        Console.WriteLine(Find3);

        Product? product1 = new(1, "Mouse", 22.99);
        Products? products = new();

        products.Add(product1);
        products.Add(2, "teclado", 216.90);
        
        Console.WriteLine(products.FindById(1));
        Console.WriteLine(products.FindById(2));

        products.Print();

        Order order1 = customer1.AddOrder();
        Console.WriteLine(order1);
        _ = customer1.AddOrder();
        Order order3 = customer1.AddOrder();
        Console.WriteLine(order3);

        Order? currentOpenOrder = customer1.GetCurrentOpenOrder();
        Console.WriteLine(currentOpenOrder);
        Order newOrder2 = customer1.AddOrder();
        Console.WriteLine(newOrder2);
        Order? order3Ref = customer1.FindOrderById(3);
        Console.WriteLine(order3Ref);

        customer1.PrintOrders();

        Console.WriteLine(customer1.FindOrderById(1));
        customer1.FindOrderById(1)?.UpdateStatus(OrderStatus.completed);
        Console.WriteLine(customer1.FindOrderById(1));

        // OrderProduct newOrder = new OrderProduct(products.FindById(1), 2);
        // Console.WriteLine(newOrder);

        customers.FindByEmail("thiago.santiago@gmail.com")?.FindOrderById(1)?
        .AddProduct(products.FindById(2), 5);
        customers.FindByEmail("thiago.santiago@gmail.com")?.FindOrderById(1)?
        .AddProduct(products.FindById(2), 2);
        customers.FindByEmail("thiago.santiago@gmail.com")?.FindOrderById(1)?
        .AddProduct(products.FindById(2), 1);

        Order? currentOrder = customers.FindByEmail("thiago.santiago@gmail.com")?
        .FindOrderById(2);
        currentOrder?.UpdateStatus(OrderStatus.Open);
        currentOrder?.AddProduct(products.FindById(1), 4);
        currentOrder?.AddProduct(products.FindById(2), 2);
        currentOrder?.AddProduct(products.FindById(1), 3);
    }
} 