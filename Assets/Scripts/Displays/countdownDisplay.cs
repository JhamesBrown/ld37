using UnityEngine;
using System.Collections;

public class countdownDisplay : MonoBehaviour {

	private string displayText;
	private float secondsRemaining;

	void Update () {

		secondsRemaining = GameManager.gameDuration - Time.time;

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
