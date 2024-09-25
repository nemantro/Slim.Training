namespace Slim.Training.DesignPatterns.Behavioral.Mediator.Plain;

public class ChatRoom
{
    private readonly List<Person> _people = new();

    public void Broadcast(string sender, string message)
    {
        foreach (var p in _people.Where(p => p.Name != sender))
        {
            p.Receive(sender, message);
        }
    }
    
    public void Message(string sender, string receiver, string message)
    {
        var target = _people.FirstOrDefault(p => p.Name == receiver);
        target?.Receive(sender, message);
    }
    
    public void Join(Person p)
    {
        p.Room = this;
        Broadcast("room", $"{p.Name} joins the chat");
        _people.Add(p);
    }
    
    public void Leave(Person p)
    {
        Broadcast("room", $"{p.Name} leaves the chat");
        p.Room = null;
        _people.Remove(p);
    }
}