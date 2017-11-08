using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects_Manager : MonoBehaviour {
	public Flower_Interaction Interaction;
	void Update()
	{
		if (Input.GetKeyDown ("g")) {
			Interaction.FlowerInteraction ();
			Debug.Log ("Trigger Grayscale");
		}
		if (Input.GetKeyDown ("r")) {
			Debug.Log ("Trigger Rain");
		}
		if (Input.GetKeyDown ("s")) {
			Debug.Log ("Trigger sunny");
		}
		if (Input.GetKeyDown ("h")) {
			Debug.Log ("Trigger Hurricane");
		}
	}
}
