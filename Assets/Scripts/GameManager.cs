using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	private bool gameIsFinished;
	public static float gameDuration = 300f;
	public float goalPopulation = 350f;
	public GameObject helpUI;
	public GameObject WinUI;
	public GameObject LoseUI;

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit ();
		}
		if (Input.GetKey(KeyCode.F1)) {
			helpUI.SetActive (true);
		} else {
			helpUI.SetActive (false);
		}
		if (Input.GetKeyDown(KeyCode.F2)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}

		
		gameIsFinished = checkFinish ();

		if (gameDuration - Time.time <= 0.0f) {
			if (gameIsFinished) {
				WinUI.SetActive (false);
			} else {
				LoseUI.SetActive (false);
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
