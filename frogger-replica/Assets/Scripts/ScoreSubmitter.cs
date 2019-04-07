using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSubmitter : MonoBehaviour
{
    public InputField NameField;

    string[] entries;

    public void SubmitScore()
    {
        NameField.characterLimit = 25;
        if(!(NameField.text == ""))
        {
            string name = NameField.text;
            int score = Stats.CurrentScore;
            Stats.CurrentScore = 0;

            UpdateScoreFile(score, name);
        }
    }

    public void UpdateScoreFile(int newScore, string name)
    {
        string newEntry = newScore.ToString() + ", " + name; //e.g. "1350, myName"

        FileManager fm = new FileManager();
        entries = fm.GetHighScoreEntries();

        // check the sores from lowest to highest
        int lowestFileScore = int.Parse(entries[2].Split(',')[0]);
        if(lowestFileScore < newScore)
        {
            entries[2] = newEntry;
        }

        SortEntries();
        fm.WriteHighScores(entries);

        SceneManager.LoadScene("EndMenu");
    }

    public void SortEntries()
    { 
        int score1 = int.Parse(entries[0].Split(',')[0]);
        int score2 = int.Parse(entries[1].Split(',')[0]);
        int score3 = int.Parse(entries[2].Split(',')[0]);

        string tempEntry = "";
        if(score3 > score2)
        {
            tempEntry = entries[2];
            entries[2] = entries[1];
            entries[1] = tempEntry;
        }
        if (score3 > score1)
        {
            tempEntry = entries[1];
            entries[1] = entries[0];
            entries[0] = tempEntry;
        }
    }
}
