namespace Slim.Training.Solid.Solid._2_OpenClosed.GoodImplementation;

public class AndSpecification<T> : ISpecification<T>
{
    private readonly ISpecification<T> _first;
    private readonly ISpecification<T> _second;
    
    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        _first = first;
        _second = second;
    }
    
    public bool IsSatisfied(T item)
    {
        return _first.IsSatisfied(item) && _second.IsSatisfied(item);
    }
}