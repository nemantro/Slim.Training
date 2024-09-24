using System.Text;

namespace Slim.Training.DesignPatterns.Creational.Builder;

public class HtmlElement
{
    private const int indentSize = 2;

    public string Name, Text;
    public List<HtmlElement> Childen = new List<HtmlElement>();
    public HtmlElement(){}
    public HtmlElement(string name, string text)
    {
        Name = name;
        Text = text;
    }
    
    //TODO finish this part using builder v2
    public FluentHtmlBuilder Create(string name, string text = "")
    {
        return new FluentHtmlBuilder(name, text);
    }

    public string Print(int previousIndentation = 0)
    {
        var sb = new StringBuilder();
        var i = new string(' ', previousIndentation);
        sb.Append($"{i}<{Name}>");
        sb.Append(Environment.NewLine);

        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append($"{i}{Text}");
            sb.Append(Environment.NewLine);
        }
            
        foreach (var child in Childen)
        {
            sb.Append(child.Print(previousIndentation + indentSize));
        }

        sb.Append($"{i}</{Name}>\n");
        return sb.ToString();
    }
}