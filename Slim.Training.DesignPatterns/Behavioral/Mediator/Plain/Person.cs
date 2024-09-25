namespace Slim.Training.DesignPatterns.Behavioral.Mediator.Plain;

public class Person
{
    //mediator example
    public string Name { get; set; }
    public ChatRoom? Room;
    private readonly List<string> _chatLog = new();
    
    public Person(string name)
    {
        Name = name;
    }
    
    public void Receive(string sender, string message)
    {
        var s = $"{sender}: '{message}'";
        _chatLog.Add(s);
    }
    
    public void SendPublicMessage(string message)
    {
        Room?.Broadcast(Name, message);
    }
    
    public void SendPrivateMessage(string receiver, string message)
    {
        Room?.Message(Name, receiver, message);
    }
}