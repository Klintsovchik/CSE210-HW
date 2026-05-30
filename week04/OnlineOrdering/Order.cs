using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    // Estimate Total cost for product + shipping
    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string result = "";
        foreach(Product product in _products)
        {
            result += $"Product Name - {product.GetName()} - ID: {product.GetProductId()}\n";
        }
        return result;
    }
    public string GetShippingLabel()
    {
        return $"Name - {_customer.GetName()}, Address - {_customer.GetAddress().GetFullAddress()}";
    }
}