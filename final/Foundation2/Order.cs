using System.Reflection.Emit;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public void DisplayTotalCost()
    {
        double totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost += product.ComputeTotalCost();
        }
        Console.WriteLine("Total: $" + Math.Round(totalCost + ComputeShippingCost(), 2));
    }
    public int ComputeShippingCost()
    {
       return _customer.LivesInUSA() ? 5 : 35;
    }
// Test this out
    public void DisplayPackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine(product.GetPackingInfo());
        }
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine(_customer.GetCustomerString());
    }
}