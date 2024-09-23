using Bad = Slim.Training.Solid.Solid._3_LiskovSubstitution.BadImplementation;
using Good = Slim.Training.Solid.Solid._3_LiskovSubstitution.GoodImplementation;

namespace Slim.Training.Solid.Solid._3_LiskovSubstitution;

public static class LiskovSubstitutionExample
{
    public static void RunBadImplementation()
    {
        Console.WriteLine("Violation of Liskov Substitution Principle");

        var duck = new Bad.Duck();
        var ostrich = new Bad.Ostrich();

        var birds = new List<Bad.Bird> { duck, ostrich };

        foreach (var bird in birds)
        {
            bird.Walk();
            bird.Fly();
        }
    }
    
    public static void RunGoodImplementation()
    {
        Console.WriteLine("Respecting Liskov Substitution Principle with better design");

        var duck = new Good.Duck();
        var sparrow = new Good.Sparrow();

        var ostrich = new Good.Ostrich();

        var birds = new List<Good.FlyingBird> { duck, sparrow };

        foreach (var bird in birds)
        {
            bird.Walk();
            bird.Fly();
        }
        
        ostrich.Run();
    }
}