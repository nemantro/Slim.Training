namespace Slim.Training.Solid._4_InterfaceSegregation.BadImplementation;

public class OldPrinter : IMachine
{
    public void Print(string text)
    {
        Console.WriteLine("Printing...");
    }
    
    public void Scan(string text)
    {
        throw new NotImplementedException("This printer can't scan");
    }
    
    public void Fax(string text)
    {
        Console.WriteLine("Fax...");
    }
}