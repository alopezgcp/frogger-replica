using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class FileManager : MonoBehaviour
{
    public Text nameText, scoreText;
    string path = "./Assets/high-scores.txt";

    private void Start()
    {
        DisplayScores();
    }

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

    public void DisplayScores()
    {
        string[] entries = GetHighScoreEntries();
        
        //display names
        string name1 = entries[0].Split(',')[1];
        string name2 = entries[1].Split(',')[1];
        string name3 = entries[2].Split(',')[1];

        string line1 = "1. " + name1;
        string line2 = "2. " + name2;
        string line3 = "3. " + name3;

        nameText.text = line1 + "\n\n" + line2 + "\n\n" + line3;

        //display scores
        string score1 = entries[0].Split(',')[0];
        string score2 = entries[1].Split(',')[0];
        string score3 = entries[2].Split(',')[0];
        
        scoreText.text = score1 + "\n\n" + score2 + "\n\n" + score3;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("HomeMenu");
    }
}
