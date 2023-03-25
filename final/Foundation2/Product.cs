// Contains the name, product id, price, and quantity of each product.
// The price of this product is computed by multiplying the price and the quantity.
public class Product 
{
    private string _productName;
    private string _productID;
    private double _productPrice;
    private double _productQuantity;

    public Product(string productName, string productID, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }
    public double getPrice()
    {
        return _productPrice;
    }

    public double getQuantity()
    {
        return _productQuantity;
    }

    public string getProductName()
    {
        return _productName;
    }

    public string getProductID()
    {
        return _productID;
    }
}