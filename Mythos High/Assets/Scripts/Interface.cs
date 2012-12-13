using UnityEngine;
using System.Collections;

public class Interface : MonoBehaviour {
	public GameObject boom;
	void OnGUI () {
		if (GUI.Button (new Rect (250,150,150,100), "Start Game")) {
			Instantiate(boom);
			Destroy (gameObject);
		}
		if (GUI.Button (new Rect (250,250,150,100), "Options")) {
			
		}
		if (GUI.Button (new Rect (250,350,150,100), "Exit")) {
			
		}
	}
}