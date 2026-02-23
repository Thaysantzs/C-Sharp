using System;

namespace OurStore;


public class OurStoreApp2
{
    public static void Main(string[] args)
    {
        Customers customers = new Customers();
        customers.Add("thiago.santiago@gmail.com", "Thiago Santiago", "Brasília");
        customers.Add("rafael.santos@gmail.com", "Rafael Santos", "Minas Gerais");
        customers.Add("marcos.sandoval@gmail.com", "Marcos Sandoval", "São Paulo");
        

        Products products = new Products();
        products.Add(
            1, "Monitor Gamer Samsung 24 FHD,100 Hz, HDMI, VGA,Preto, S3", 565
        );
        products.Add(
            2, "Placa de Video MSI RTX 5060 Shadow 2X OC, 8GB, GDDR7-912-V537-037", 2440
        );
        products.Add(
            3, "Placa Mae Gigabyte B550M Aorus Elite AX, WiFi, DDR4, Socket AMD AM4, M-ATX, Chipset AMD B550, B550M-AORUS-ELITE-AX",
            999.90
        );


        Customer? customer = customers.FindByEmail("thiago.santiago@gmail.com");
        Console.WriteLine(customer);
        Order order = customer.AddOrder();
        order.AddProduct(products.FindById(3), 2);
        order.AddProduct(products.FindById(1), 2);
        order.AddProduct(products.FindById(2), 2);
        Console.WriteLine($"Order Total: order: {order.Total}");
        customer.PrintOrders();
        order.UpdateStatus(OrderStatus.completed);
        customer.PrintOrders(); 
    }
} 