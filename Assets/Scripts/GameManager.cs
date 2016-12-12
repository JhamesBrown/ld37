using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	private bool gameIsFinished;
	public static float gameDuration = 20f;
	public float goalPopulation = 400f;

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit ();
		}
		if (Input.GetKeyDown(KeyCode.F1)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}

		
		gameIsFinished = checkFinish ();

		if (gameDuration - Time.time <= 0.0f) {
			if (gameIsFinished) {
				Debug.Log ("GAME WAS WON");
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			} else {
				Debug.Log ("GAME HAS BEEN LOST");
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
			}
		}

	}

	bool checkFinish()
	{
		if (ResourceManager.population >= goalPopulation) {
			return true;
		} else {
			return false;
		}
	}
}
