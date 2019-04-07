using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
    
	void OnTriggerEnter2D ()
	{
		Stats.CurrentScore += 50 * Stats.Difficulty * Stats.Difficulty;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
