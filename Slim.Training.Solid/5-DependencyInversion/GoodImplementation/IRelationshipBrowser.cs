namespace Slim.Training.Solid._5_DependencyInversion.GoodImplementation;

public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}