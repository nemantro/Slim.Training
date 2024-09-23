namespace Slim.Training.Solid._3_LiskovSubstitution.BadImplementation;

public class Bird
{
    public virtual string Walk()
    {
        return "Follow my steps";
    }
    
    public virtual string Fly()
    {
        return "I can fly high in the sky";
    }
}