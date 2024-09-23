namespace Slim.Training.Solid.Solid._5_DependencyInversion.BadImplementation;

// low-level
public class Relationships
{
    public List<(Person Person1, Relationship Relationship, Person Person2)> Relations = new List<(Person, Relationship, Person)>();

    public void AddParentAndChild(Person parent, Person child)
    {
        Relations.Add((parent, Relationship.Parent, child));        
        Relations.Add((child, Relationship.Child, parent));        
    }
}