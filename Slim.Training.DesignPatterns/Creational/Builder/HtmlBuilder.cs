namespace Slim.Training.DesignPatterns.Creational.Builder;

public class HtmlBuilder
{
    private readonly HtmlElement _root = new();
    
    public HtmlBuilder(string rootName, string rootText = "")
    {
        _root.Text = rootText;
        _root.Name = rootName;
    }

    public void AddChild(string childName, string childText)
    {
        _root.Childen.Add(new HtmlElement(childName, childText));
    }
    
    public string Build()
    {
        return _root.Print();
    }
}

public class FluentHtmlBuilder
{
    private HtmlElement _root = new();
    
    public FluentHtmlBuilder(string rootName, string rootText = "")
    {
        _root.Name = rootName;
        _root.Text = rootText;
    }

    public FluentHtmlBuilder AddChild(string childName, string childText)
    {
        _root.Childen.Add(new HtmlElement(childName, childText));
        return this;
    }
    
    public string Build()
    {
        return _root.Print();
    }
}