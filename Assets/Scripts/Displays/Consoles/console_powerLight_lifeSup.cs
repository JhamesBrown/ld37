using UnityEngine;
using System.Collections;

public class console_powerLight_lifeSup : MonoBehaviour {

	private Renderer renderer;

	public Material consolePowered;
	public Material consoleUnPowered;

	// Use this for initialization
	void Start () {
		renderer = GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () {
		if (ResourceManager.currentPowerUse == ResourceManager.powerUse.PoweredLifeSupportCharger) {
			renderer.material = consolePowered;
		} else {
			renderer.material = consoleUnPowered;
		}
	}
}
