namespace Slim.Training.Solid._5_DependencyInversion;

using RelationshipProcessor = BadImplementation.RelationshipProcessor;
using Relationships = BadImplementation.Relationships;

public static class DependencyInversionExample
{
    public static void RunBadImplementation()
    {
        Console.WriteLine("Violation of Dependency Inversion Principle because high-level module RelationshipProcessor depends on low-level module Relationships");
        
        var relationships = new Relationships();
        var research = new RelationshipProcessor(relationships);
    }

    public static void RunGoodImplementation()
    {
        Console.WriteLine("An abstraction is introduced to decouple high-level module RelationshipProcessor from low-level module Relationships");

        
    }
}