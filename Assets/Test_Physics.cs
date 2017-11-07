using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Physics : MonoBehaviour {
	public float forceAmount = 1000f;

	void OnMouseDown()
	{
		Debug.Log ("Oella");
		GetComponent<Rigidbody>().AddForce (-transform.forward * forceAmount, ForceMode.Acceleration);
		GetComponent<Rigidbody>().useGravity = true;
	}
}
