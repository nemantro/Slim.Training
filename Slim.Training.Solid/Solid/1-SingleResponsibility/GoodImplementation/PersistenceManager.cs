namespace Slim.Training.Solid.Solid._1_SingleResponsibility.GoodImplementation;

public class PersistenceManager
{
    public void SaveToFile(Journal goodImplementation, string filename, bool overwrite = false)
    {
        if (overwrite || !File.Exists(filename))
        {
            File.WriteAllText(filename, goodImplementation.ToString());
        }
    }
}