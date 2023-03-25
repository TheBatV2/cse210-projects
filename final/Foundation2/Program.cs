using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("IronMan Mini", "2", 34.99, 1);
        Product product2 = new Product("Batman Mini", "5", 44.99, 1);
        Product product3 = new Product("Skeleton Minis", "1", 19.99, 10);
        Product product4 = new Product("Mando Mini", "7", 24.99, 1);
        

        Order order1 = new Order();
        Address address1 = new Address("41 Johnson St", "Blackfoot", "ID", "USA");
        Customer customer1 = new Customer("Spencer Barbre", address1);

        order1.AddToCart(product2);
        order1.AddToCart(product4);
        order1.displayTotalCost(address1);
        order1.packingLabel();
        order1.shippingLabel(address1, customer1);

        Console.WriteLine("");


        Order order2 = new Order();
        Address address2 = new Address("85 Johnson St", "Blackfoot", "ID", "USA");
        Customer customer2 = new Customer("Rudy Sanchez", address2);

        order2.AddToCart(product3);
        order2.AddToCart(product4);
        order2.displayTotalCost(address2);
        order2.packingLabel();
        order2.shippingLabel(address2, customer2);

        Console.WriteLine("");

        Order order3 = new Order();
        Address address3 = new Address("204 Johnson rd", "Blackfoot", "ID", "USA");
        Customer customer3 = new Customer("JoAnn Barbre", address3);

        order3.AddToCart(product1);
        order3.AddToCart(product1);
        order3.AddToCart(product4);
        order3.displayTotalCost(address3);
        order3.packingLabel();
        order3.shippingLabel(address3, customer3);
        

        


    }
}