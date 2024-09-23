namespace Slim.Training.Solid._4_InterfaceSegregation.SpecialCaseOfConstructors;

public class Printer
{
    public Printer(string uniqueId, string color = "White", bool hasWifiInterface = true , string paperSize = "A4", string region = "Europe")
    {
        // consume those
    }

    public Printer(PrinterOptions parameters)
    {
        // consume those
    }
}

public class PrinterOptions
{
    public string UniqueId;
    public string Color = "White";
    public bool HasWifiInterface = true;
    public string PaperSize = "A4";
    public string Region = "Europe";

    public PrinterOptions(string uniqueId)
    {
        UniqueId = uniqueId;
    }
}