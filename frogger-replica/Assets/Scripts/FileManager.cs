using System.IO;

public class FileManager
{
    string path = "./Assets/high-scores.txt";
    
    public string[] GetHighScoreEntries()
    {
        string[] entries = new string[3];
        string line = null;

        using(StreamReader sr = new StreamReader(path))
        {
            int lineCount = 0;
            while ((line = sr.ReadLine()) != null)
            {
                entries[lineCount] = line;
                ++lineCount;
            }
        }

        return entries;
    }

    public void WriteHighScores(string[] entries)
    {
        using(StreamWriter sw = new StreamWriter(path))
        {
            foreach(string entry in entries)
            {
                sw.WriteLine(entry);
            }
        }
    }
}
