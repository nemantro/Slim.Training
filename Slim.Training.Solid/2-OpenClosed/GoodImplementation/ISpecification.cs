namespace Slim.Training.Solid._2_OpenClosed.GoodImplementation;

public interface ISpecification<T>
{
    bool IsSatisfied(T item);
}