namespace Slim.Training.Solid.Solid._3_LiskovSubstitution.BadImplementation;

public class Duck : Bird
{
    public string Swim()
    {
        return "I can swim too";
    }
}