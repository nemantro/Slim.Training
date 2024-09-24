using Slim.Training.DesignPatterns.Creational.Builder;

RunBuilderPatternExample();

Console.ReadLine();

void RunBuilderPatternExample()
{
    HtmlRenderer.RenderBulletListV0();

    HtmlRenderer.RenderBulletListV1();
    
    HtmlRenderer.RenderUsingBuilder();    
    
    HtmlRenderer.RenderUsingFluentBuilder();
    
    HtmlRenderer.RenderUsingOnlyFluentBuilder();    
}