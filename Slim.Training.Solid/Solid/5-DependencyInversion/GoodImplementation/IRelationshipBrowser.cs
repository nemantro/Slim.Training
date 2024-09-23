namespace Slim.Training.Solid.Solid._5_DependencyInversion.GoodImplementation;

public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}