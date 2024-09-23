namespace Slim.Training.Solid._4_InterfaceSegregation.GoodImplementation;

public class MultiFunctionPrinter : IMultiFunctionPrinter
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
        Console.WriteLine("Faxing...");
    }
}