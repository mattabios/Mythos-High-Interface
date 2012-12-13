using UnityEngine;
using System.Collections;

public class Next : MonoBehaviour {
	public GameObject boom;
	void OnGUI () {
		GUI.Box (new Rect (100,250,150,100), "HI");
		if (GUI.Button (new Rect (250,250,150,100), "Next")) {
			
			Instantiate(boom);
			Destroy (gameObject);
		}
	}
}
