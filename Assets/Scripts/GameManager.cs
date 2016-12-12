using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	private bool gameIsFinished;

	public bool[] winConditionsMeet = new bool[3];

	void Start () 
	{
		for (int i = 0; i < winConditionsMeet.Length; i++)
			winConditionsMeet [i] = false;
	}
	

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Escape)) {
			Application.Quit ();
		}
		if (Input.GetKeyDown(KeyCode.F1)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
		}

		
		gameIsFinished = checkFinish ();

		if (gameIsFinished)
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	bool checkFinish()
	{
		foreach (bool condition in winConditionsMeet) {
			if (!condition)
				return false;
		}
		return true;
	}
}
