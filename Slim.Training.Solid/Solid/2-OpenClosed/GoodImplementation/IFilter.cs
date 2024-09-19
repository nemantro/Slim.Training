namespace Slim.Training.Solid.Solid._2_OpenClosed.GoodImplementation;

public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
}