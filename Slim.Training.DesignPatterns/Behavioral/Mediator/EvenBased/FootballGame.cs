namespace Slim.Training.DesignPatterns.Behavioral.Mediator.EvenBased;

public class FootballGame
{
    public event EventHandler<GameEventArgs>? Events;

    public void Fire(GameEventArgs args)
    {
        Events?.Invoke(this, args);
    }
}