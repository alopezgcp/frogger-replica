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
            DiffText.text = "Low risk, low reward.";
        }
        else if (Stats.Difficulty == 2)
        {
            DiffText.text = "A slightly less casual experience.";
        }
        else if (Stats.Difficulty == 3)
        {
            DiffText.text = "Mad props for mad hops.";
        }
    }

    public void StartGame()
    {
        if (Stats.Difficulty == 0)
        {
            DiffText.text = "Select a difficulty to start the game.";
        }
        else
        {
            Stats.timeOffset = Time.time;
            SceneManager.LoadScene("Main");
        }
    }
}
