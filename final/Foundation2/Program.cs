using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new(
        // List<Products>
            new List<Product>
            {
                new("Apple", 1, 0.99, 1),
                new("Banana", 2, 0.50, 1),
                new("Pineapple", 3, 1.99, 1)
            },
        // Customer
            new
            (
                "Bryan", 
        // Address
                new
                (
                    "123 Main Avenue",
                    "London",
                    "England",
                    "United Kingdom"
                )
            )
        );
        order1.DisplayShippingLabel();
        order1.DisplayPackingLabel();
        order1.DisplayTotalCost();

        Order order2 = new(
        // List<Products>
            new List<Product>
            {
                new("Potato Chips", 4, 4.99, 1),
                new("Yogurt", 5, 0.99, 1),
                new("Lettuce", 6, 0.99, 1)
            },
        // Customer
            new
            (
                "Randy", 
        // Address
                new
                (
                    "4819 Terrell Terrace",
                    "Memphis",
                    "Tennessee",
                    "United States"
                )
            )
        );
        order2.DisplayShippingLabel();
        order2.DisplayPackingLabel();
        order2.DisplayTotalCost();
    }
}