namespace Slim.Training.Solid._3_LiskovSubstitution.GoodImplementation;

public class Bird
{
    public virtual string Walk()
    {
        return "Follow my steps";
    }

    public bool HasWings => true;

    public bool LaysEggs => true;
}

public class FlyingBird : Bird
{
    public virtual string Fly()
    {
        return "I can fly high in the sky";
    }
}