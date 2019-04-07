using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {

	public static int CurrentScore = 0;
    public static int Difficulty = 3;
    public static float timeOffset = 0f;

    private int min = 0;
    private int sec = 0;
    private int ms = 0;

    public Text scoreText;
    public Text timerText;

	void Start ()
    { 
		scoreText.text = CurrentScore.ToString();
	}

    private void Update()
    {
        // update game clock
        min = (int)(Time.time - timeOffset) / 60;
        sec = (int)(Time.time -timeOffset) % 60;
        ms = (int)((Time.time - timeOffset) * 100) % 100;
        timerText.text = min.ToString("00") + ":" + sec.ToString("00") + ":" + ms.ToString("00");
    }
}
