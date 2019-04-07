using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {

	public static int CurrentScore = 0;
    public static int Difficulty = 3;

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
        min = (int)Time.time / 60;
        sec = (int)Time.time % 60;
        ms = (int)(Time.time * 100) % 100;
        timerText.text = min.ToString("00") + ":" + sec.ToString("00") + ":" + ms.ToString("00");
    }
}
