namespace Slim.Training.DesignPatterns.Behavioral.Mediator.EvenBased;

public class Player
{
    private string _name;
    private int _goalsScored;
    private FootballGame _footballGame;

    public Player(string name, FootballGame footballGame)
    {
        _name = name;
        _footballGame = footballGame;
    }

    public void Score()
    {
        _goalsScored++;
        var args = new PlayerScoredEventArgs(_name, _goalsScored);
        _footballGame.Fire(args);
    }
}