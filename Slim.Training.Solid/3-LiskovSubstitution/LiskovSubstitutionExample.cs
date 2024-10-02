namespace Slim.Training.Solid._3_LiskovSubstitution;

using Bird = BadImplementation.Bird;
using Duck = BadImplementation.Duck;
using FlyingBird = GoodImplementation.FlyingBird;
using GoodImplementation_Duck = GoodImplementation.Duck;
using GoodImplementation_Ostrich = GoodImplementation.Ostrich;
using Ostrich = BadImplementation.Ostrich;
using Sparrow = GoodImplementation.Sparrow;

public static class LiskovSubstitutionExample
{
    public static void RunBadImplementation()
    {
        Console.WriteLine("Violation of Liskov Substitution Principle");

        var duck = new Duck();
        var ostrich = new Ostrich();

        var birds = new List<Bird> { duck, ostrich };

        foreach (var bird in birds)
        {
            bird.Walk();
            bird.Fly();
        }
    }
    
    public static void RunGoodImplementation()
    {
        Console.WriteLine("Respecting Liskov Substitution Principle with better design");

        var duck = new GoodImplementation_Duck();
        var sparrow = new Sparrow();

        var ostrich = new GoodImplementation_Ostrich();

        var flyingBirds = new List<FlyingBird> { duck, sparrow };

        foreach (var bird in flyingBirds)
        {
            bird.Walk();
            bird.Fly();
        }
        
        ostrich.Run();
    }
}