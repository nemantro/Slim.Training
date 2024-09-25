namespace Slim.Training.DesignPatterns.Behavioral.Mediator.EvenBased;

public static class FootballGameMediatorExample
{
    public static void Run()
    {
        Console.WriteLine("Football Game Mediator Example");
        
        var game = new FootballGame();

        var player1 = new Player("John", game);
        var player2 = new Player("Chris", game);

        var coach = new Coach(game);
        
        
        player1.Score();
        player1.Score();
        player2.Score();
    }
}