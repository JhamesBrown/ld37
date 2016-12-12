using UnityEngine;
using System.Collections;

public class countdownDisplay : MonoBehaviour {


	private float gameDuration = 300f; // This will be got from the gamemanager or resource manager depending on whats used for end game logic
	private string displayText;
	private float secondsRemaining;

	void Update () {

		secondsRemaining = gameDuration - Time.time;

		displayText = "COUNTDOWN \n" + timeTextFormat(Mathf.Floor(secondsRemaining)); 
		GetComponent<TextMesh> ().text = displayText;

	}

	string timeTextFormat(float secs)
	{
		int min = Mathf.FloorToInt(secs/60);
		int sec = Mathf.FloorToInt(secs) - (min * 60);

		return min + ":" + sec; 
	}
}
