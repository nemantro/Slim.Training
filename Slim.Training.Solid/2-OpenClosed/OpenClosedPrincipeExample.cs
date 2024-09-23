using Slim.Training.Solid._2_OpenClosed.BadImplementation;
using Slim.Training.Solid._2_OpenClosed.GoodImplementation;

namespace Slim.Training.Solid._2_OpenClosed;

public static class OpenClosedPrincipeExample
{
    private static readonly List<Product> Products =
    [
        new Product("p1", Color.Blue, Size.Large),
        new Product("p2", Color.Red, Size.Large),
        new Product("p3", Color.Green, Size.Small),
        new Product("p4", Color.Green, Size.Large)
    ];
    
    public static void RunBadImplementation()
    {
        Console.WriteLine("Green products bad implementation:");
        
        var productFilter = new ProductFilterBad();
        foreach (var product in productFilter.FilterByColor(Products, Color.Green))
        {
            Console.WriteLine($" - {product.Name} is green");
        }
    }
    
    public static void RunGoodImplementation()
    {
        Console.WriteLine("Green products good implementation:");
        
        var colorSpecification = new ColorSpecification(Color.Green);
        var betterFilter = new BetterFilter();
        foreach (var product in betterFilter.Filter(Products, colorSpecification))
        {
            Console.WriteLine($" - {product.Name} is green");
        }
        
        var sizeSpecification = new SizeSpecification(Size.Large);
        var andSpecification = new AndSpecification<Product>(colorSpecification, sizeSpecification);
        foreach (var product in betterFilter.Filter(Products, andSpecification))
        {
            Console.WriteLine($" - {product.Name} is green and large");
        }
    }
}