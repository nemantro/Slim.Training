namespace Slim.Training.Solid.Solid._3_LiskovSubstitution.GoodImplementation;

public class Duck : FlyingBird
{
    public string Swim()
    {
        return "I can swim too";
    }
}