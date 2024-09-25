using Slim.Training.DesignPatterns.Behavioral.Mediator.EvenBased;
using Slim.Training.DesignPatterns.Behavioral.Mediator.Plain;
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

void RunMediatorPatternExample()
{
    ChatRoomMediatorExample.Run();
    
    FootballGameMediatorExample.Run();
}