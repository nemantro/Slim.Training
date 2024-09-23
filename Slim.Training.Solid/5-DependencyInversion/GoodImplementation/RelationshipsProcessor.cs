//high-level 

namespace Slim.Training.Solid._5_DependencyInversion.GoodImplementation;

public class RelationshipProcessor
{
    private readonly IRelationshipBrowser _relationshipBrowser;

    public RelationshipProcessor(IRelationshipBrowser relationshipBrowser)
    {
        _relationshipBrowser = relationshipBrowser;
    }

    public void ProcessChildren()
    {
        foreach (var person in _relationshipBrowser.FindAllChildrenOf("John"))
        {
            Console.WriteLine("John has a child called " + person.Name);
        }
    }
}