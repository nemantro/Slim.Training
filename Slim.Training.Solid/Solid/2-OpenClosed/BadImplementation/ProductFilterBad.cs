namespace Slim.Training.Solid.Solid._2_OpenClosed.BadImplementation;

public class ProductFilterBad
{
    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        foreach (var product in products)
        {
            if (product.Color == color)
            {
                yield return product;
            }
        }
    }

    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        foreach (var product in products)
        {
            if (product.Size == size)
            {
                yield return product;
            }
        }
    }
    
    public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
    {
        foreach (var product in products)
        {
            if (product.Size == size && product.Color == color)
            {
                yield return product;
            }
        }
    }
}