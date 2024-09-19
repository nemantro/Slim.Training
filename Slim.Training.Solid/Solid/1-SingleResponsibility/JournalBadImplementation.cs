namespace Slim.Training.Solid.Solid._1_SingleResponsibility;

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