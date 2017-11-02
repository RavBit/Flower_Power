using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower_Trigger : MonoBehaviour {
	public RayCastMouse RCM;
	// Use this for initialization

	void Start()
	{
		//RCM.RemoveColours (10);
	}
	void OnCollisionEnter(Collision other)
	{
		Debug.Log ("COLLISION " + other.gameObject.name);
		if (other.gameObject.tag == "Hands") {
			RCM.RemoveColours (10);
		}

	}
}
