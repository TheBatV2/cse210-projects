// Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
// The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer
public class Order
{
    private List<Product> _products = new List<Product>();

    public void AddToCart(Product product)
    {
        _products.Add(product);
    }

    private double calculateCost()
    {
        double cost = 0;
        foreach (Product p in _products)
        {
            cost += (p.getPrice() * p.getQuantity());
        }
        return cost;
    }

    private double calculateShippingCost(Address address)
    {
        double shippingCost;
            if (address.GetCountry() == "USA")
            {
                shippingCost = 5;
            }
            else
            {
                shippingCost = 35;
            }
            return shippingCost;
    }



    private double totalCost(Address address)
    {
        double cost = calculateCost();
        double shippingCost = calculateShippingCost(address);
        double total = cost + shippingCost;
        return total;
    }

    public void displayTotalCost(Address address)
    {
        Console.WriteLine($"Total:{totalCost(address)}");
    }

    public void packingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.getProductID()}: {product.getProductName()}");
        }
    }

    public void shippingLabel(Address address, Customer customer)
    {
        Console.WriteLine(address.GetShippingLabel(customer));
    }


}