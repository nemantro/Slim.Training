namespace Slim.Training.Solid._3_LiskovSubstitution.BadImplementation;

public class Ostrich : Bird
{
    public override string Fly()
    {
        throw new NotSupportedException("I can't fly");
    }
}