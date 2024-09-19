namespace Slim.Training.Solid.Solid._1_SingleResponsibility;

public static class SingleResponsibilityExample
{
    public static void RunBadImplementation()
    {
        var journal = new JournalBadImplementation();
        journal.AddEntry("Entry 1");
        journal.AddEntry("Entry 2");
        journal.AddEntry("Entry 3");
        journal.RemoveEntry(1);

        Console.WriteLine(journal);

        journal.SaveToFile("SingleResponsibilityExampleBad.txt", overwrite: true);
    }

    public static void RunGoodImplementation()
    {
        var journal = new Journal();
        journal.AddEntry("Entry 1");
        journal.AddEntry("Entry 2");
        journal.AddEntry("Entry 3");
        journal.RemoveEntry(1);

        Console.WriteLine(journal);

        var persistenceManager = new PersistenceManager();
        persistenceManager.SaveToFile(journal, "SingleResponsibilityExample.txt", overwrite: true);
    }
}