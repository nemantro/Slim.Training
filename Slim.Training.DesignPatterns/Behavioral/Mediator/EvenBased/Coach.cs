namespace Slim.Training.DesignPatterns.Behavioral.Mediator.EvenBased;

public class Coach
{
    public Coach(FootballGame footballGame)
    {
        footballGame.Events += OnGameEvent;
    }

    private void OnGameEvent(object sender, GameEventArgs e)
    {
        if (e is PlayerScoredEventArgs scored)
        {
            if (scored.GoalsScored > 2)
            {
                Console.WriteLine($"Coach: excellent job, {scored.PlayerName}!");
            }
        }
    }
}