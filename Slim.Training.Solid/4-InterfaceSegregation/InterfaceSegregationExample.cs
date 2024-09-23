using Slim.Training.Solid._4_InterfaceSegregation.BadImplementation;
using Slim.Training.Solid._4_InterfaceSegregation.GoodImplementation;
using Slim.Training.Solid._4_InterfaceSegregation.SpecialCaseOfConstructors;

namespace Slim.Training.Solid._4_InterfaceSegregation;

public static class InterfaceSegregationExample
{
    public static void RunBadImplementation()
    {
        Console.WriteLine("This will fail because the interface is not granular enough");
        
        IMachine extraPrinter = new NewPrinter();
        IMachine simplePrinter = new OldPrinter();
        
        var printers = new List<IMachine> { extraPrinter, simplePrinter };
        
        printers.ForEach(printer =>
        {
            printer.Print("Hello World");
            printer.Scan("Hello World");
            printer.Fax("Hello World");
        });
        
        // in case of a contructor : 
        var printer = new Printer("uniqueId");
    }
    
    public static void RunGoodImplementation()
    {
        Console.WriteLine("This will succeed because the interfaces are granular");
        
        IPrinter simplePrinter = new SimplePrinter();
        IMultiFunctionPrinter multiFunctionPrinter = new MultiFunctionPrinter();
        
        var printers = new List<IPrinter> { simplePrinter, multiFunctionPrinter };
        
        printers.ForEach(printer =>
        {
            printer.Print("Hello World");
        });
        
        multiFunctionPrinter.Scan("Scan Hello World from MultiFunctionPrinter");
        
        // in case of a contructor prefer using parameters rather than optional parameters: 
        var printer = new Printer(new PrinterOptions("uniqueId"));
    }
}