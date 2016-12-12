using UnityEngine;
using System.Collections;

public class AlarmLight : MonoBehaviour {

	private Renderer renderer;
	private ResourceManager resourceManager;

	public GameObject AlarmAudioChild;

	// Use this for initialization
	void Start () {
		resourceManager = GameObject.Find ("ResourceManager").GetComponent<ResourceManager>();
		renderer = GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () {
		Material mat = renderer.material;
		if (resourceManager.heat * 100f > 80f) {
			

			float emission = Mathf.PingPong (Time.time, 1.0f);
			Color baseColor = Color.red; //Replace this with whatever you want for your base color at emission level '1'

			Color finalColor = baseColor * Mathf.LinearToGammaSpace (emission);
			mat.SetColor ("_Color", Color.red);
			mat.SetColor ("_EmissionColor", finalColor);

			if (AlarmAudioChild != null) {
				AlarmAudioChild.SetActive (true);
			}
		} else {
			mat.SetColor ("_Color", Color.gray);
			mat.SetColor("_EmissionColor", Color.black);
			if (AlarmAudioChild != null) {
				AlarmAudioChild.SetActive (false);
			}
		}


	}
}
