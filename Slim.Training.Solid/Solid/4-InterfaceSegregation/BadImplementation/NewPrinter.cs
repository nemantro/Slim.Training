namespace Slim.Training.Solid.Solid._4_InterfaceSegregation.BadImplementation;

public class NewPrinter : IMachine
{
    public void Print(string text)
    {
        Console.WriteLine("Printing...");
    }
    
    public void Scan(string text)
    {
        Console.WriteLine("Scanning...");
    }
    
    public void Fax(string text)
    {
        throw new NotImplementedException("I don't even know what a fax is");
    }
}