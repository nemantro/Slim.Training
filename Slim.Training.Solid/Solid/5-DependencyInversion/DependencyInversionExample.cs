using Bad =Slim.Training.Solid.Solid._5_DependencyInversion.BadImplementation;

namespace Slim.Training.Solid.Solid._5_DependencyInversion;

public static class DependencyInversionExample
{
    public static void RunBadImplementation()
    {
        Console.WriteLine("Violation of Dependency Inversion Principle because high-level module RelationshipProcessor depends on low-level module Relationships");
        
        var relationships = new Bad.Relationships();
        var research = new Bad.RelationshipProcessor(relationships);
    }

    public static void RunGoodImplementation()
    {
        Console.WriteLine("An abstraction is introduced to decouple high-level module RelationshipProcessor from low-level module Relationships");

        
    }
}