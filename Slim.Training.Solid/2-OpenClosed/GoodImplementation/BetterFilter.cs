namespace Slim.Training.Solid._2_OpenClosed.GoodImplementation;

public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
    {
        foreach (var product in items)
        {
            if (specification.IsSatisfied(product))
            {
                yield return product;
            }
        }
    }
}