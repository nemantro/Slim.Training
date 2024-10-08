namespace Slim.Training.Solid._2_OpenClosed.GoodImplementation;

public class SizeSpecification : ISpecification<Product>
{
    private readonly Size _size;
    
    public SizeSpecification(Size size)
    {
        _size = size;
    }
    
    public bool IsSatisfied(Product item)
    {
        return item.Size == _size;
    }
}