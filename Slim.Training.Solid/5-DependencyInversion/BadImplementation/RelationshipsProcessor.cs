namespace Slim.Training.Solid._5_DependencyInversion.BadImplementation;

//high-level 
public class RelationshipProcessor
{
    private readonly Relationships _relationships;

    public RelationshipProcessor(Relationships relationships)
    {
        _relationships = relationships;
    }

    public void ProcessChildren()
    {
        var relations = _relationships.Relations;
        foreach (var relation in
                 relations.Where(p => p.Person1.Name == "John" && p.Relationship == Relationship.Parent))
        {
            Console.WriteLine("John has a child called " + relation.Person2.Name);
        }
    }
}