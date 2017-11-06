using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {
	public OVRInput.Controller controller;
	public string buttonname;
	[Range(0,10)]
	public float grabRadius;
	public LayerMask grabMask;

	private GameObject grabbedObject;
	private bool grabbing;

	void GrabObject()
	{
		grabbing = true;

		RaycastHit[] hits;

		hits = Physics.SphereCastAll (transform.position, grabRadius, transform.forward, 0f, grabMask);

		if(hits.Length > 0)
		{
			Debug.Log ("GRAB OBJECT");
			int closestHit = 0;
			for (int i = 0; i < hits.Length; i++) {
				if (hits [i].distance > hits [closestHit].distance)
					closestHit = i;
			}
			grabbedObject = hits [closestHit].transform.gameObject;
			grabbedObject.GetComponent<Rigidbody> ().isKinematic = true;
			grabbedObject.transform.position = transform.position;
			grabbedObject.transform.parent = transform;
			if (grabbedObject.GetComponent<Flower_Interaction> () != null)
				grabbedObject.GetComponent<Flower_Interaction> ().FlowerInteraction ();
		}
	}

	void DropObject()
	{
		if (grabbedObject != null) {
			grabbedObject.transform.parent = null;
			grabbedObject.GetComponent<Rigidbody> ().velocity = OVRInput.GetLocalControllerAngularVelocity (controller);
			grabbedObject.GetComponent<Rigidbody> ().isKinematic = false;
			grabbedObject = null;
		}
		grabbing = false;
	}

	void Update()
	{
		if (!grabbing && Input.GetAxis (buttonname) == 1)
			GrabObject ();
		if (grabbing && Input.GetAxis (buttonname) < 1)
			DropObject ();
	}
}
