using System.Text;

namespace Slim.Training.DesignPatterns.Creational.Builder;

public static class HtmlRenderer
{
    #region no pattern

    public static void RenderBulletListV0()
    {
        Console.WriteLine("using string builder only (no structure)");
        
        List<string> words = ["hello", "world"];

        var sb = new StringBuilder();
        sb.Append("<ul>");
        foreach (var word in words)
        {
            sb.Append($"<li>{word}</li>");
        }

        sb.Append("</ul>");
        var result = sb.ToString();
        
        Console.WriteLine(result);
    }
    
    public static void RenderBulletListV1()
    {
        Console.WriteLine("using HTMLElement structure - but building it manually");
        
        List<string> words = ["hello", "world"];

        var tag = new HtmlElement("ui", null);
        foreach (var word in words)
        {
            tag.Childen.Add(new HtmlElement("li", word));
        }

        Console.WriteLine(tag.Print());
    }
    
    #endregion

    #region builder

    public static void RenderUsingBuilder()
    {
        Console.WriteLine("using HTMLBuilder to build HTMLElement");

        var builder = new HtmlBuilder("ul");
        builder.AddChild("li", "hello");
        builder.AddChild("li", "world");
        Console.WriteLine(builder.Build());
    }
    
    public static void RenderUsingFluentBuilder()
    {
        Console.WriteLine("using Fluent HTMLBuilder to build HTMLElement");
        
        var result = new FluentHtmlBuilder("ul")
        .AddChild("li", "hello")
        .AddChild("li", "world")
        .Build();
        
        Console.WriteLine(result);
    }

    #endregion

    public static void RenderUsingOnlyFluentBuilder()
    {
        throw new NotImplementedException();
    }
}