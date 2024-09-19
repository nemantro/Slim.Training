namespace Slim.Training.Solid;

public class JournalBadImplementation
{
    private readonly List<string> _entries = new List<string>();

    // Counter for the total # of entries
    private static int _count = 0;

    public void AddEntry(string text)
    {
        _entries.Add($"{++_count}: {text}");
    }

    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }

    public void SaveToFile(string filename, bool overwrite = false)
    {
        if (overwrite || !File.Exists(filename))
        {
            File.WriteAllText(filename, ToString());
        }
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, _entries);
    }
}

public class Journal
{
    private readonly List<string> _entries = new List<string>();

    // Counter for the total # of entries
    private static int _count = 0;

    public void AddEntry(string text)
    {
        _entries.Add($"{++_count}: {text}");
    }

    public void RemoveEntry(int index)
    {
        _entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, _entries);
    }
}

public class PersistenceManager
{
    public void SaveToFile(Journal journal, string filename, bool overwrite = false)
    {
        if (overwrite || !File.Exists(filename))
        {
            File.WriteAllText(filename, journal.ToString());
        }
    }
}

public class SingleResponsibilityExample
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