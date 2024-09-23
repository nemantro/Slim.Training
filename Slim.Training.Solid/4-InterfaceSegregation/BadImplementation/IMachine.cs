namespace Slim.Training.Solid._4_InterfaceSegregation.BadImplementation;

public interface IMachine
{
    void Print(string text);
    void Scan(string text);
    void Fax(string text);
}