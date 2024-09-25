namespace Slim.Training.DesignPatterns.Behavioral.Mediator.EvenBased;

public class PlayerScoredEventArgs : GameEventArgs
{
    public string PlayerName { get; set; }
    public int GoalsScored { get; set; }

    public PlayerScoredEventArgs(string playerName, int goalsScored)
    {
        PlayerName = playerName;
        GoalsScored = goalsScored;
    }

    public override void Print()
    {
        Console.WriteLine($"{PlayerName} has scored {GoalsScored} goals.");
    }
}