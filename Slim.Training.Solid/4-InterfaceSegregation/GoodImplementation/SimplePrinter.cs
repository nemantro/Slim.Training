namespace Slim.Training.Solid._4_InterfaceSegregation.GoodImplementation;

public class SimplePrinter : IPrinter
{
    public void Print(string text)
    {
        Console.WriteLine("Printing...");
    }
}