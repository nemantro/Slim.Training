namespace Slim.Training.DesignPatterns.Behavioral.Mediator.Plain;

public static class ChatRoomMediatorExample
{
    public static void Run()
    {
        Console.WriteLine("Chat Room Mediator Example");
        
        var room = new ChatRoom();
        var john = new Person("John");
        var jane = new Person("Jane");
        
        room.Join(john);
        room.Join(jane);
        
        john.SendPublicMessage("hi room");
        jane.SendPublicMessage("oh hey john");
        
        var simon = new Person("Simon");
        room.Join(simon);
        simon.SendPublicMessage("hi everyone!");
        
        jane.SendPrivateMessage("Simon", "glad you could join us!");
    }
}