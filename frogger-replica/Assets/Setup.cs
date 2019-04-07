using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Setup : MonoBehaviour
{
    public Text DiffText;
    
    void Start()
    {
        Stats.Difficulty = 0;
    }

    public void SetDifficulty(int d)
    {
        Stats.Difficulty = d;
        SetDiffText();
    }

    public void SetDiffText()
    {
        if(Stats.Difficulty == 1)
        {
            DiffText.text = "Couldn't lose if you wanted to.";
        }
        else if (Stats.Difficulty == 2)
        {
            DiffText.text = "Still a pretty casual game.";
        }
        else if (Stats.Difficulty == 3)
        {
            DiffText.text = "The skill gap is real; good luck.";
        }
    }

    public void StartGame()
    {
        if(Stats.Difficulty == 0)
        {
            DiffText.text = "Select a difficulty to start the game.";
        }
        else SceneManager.LoadScene("Main");
    }
}
