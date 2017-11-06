using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundCheck : MonoBehaviour {
	public GameObject test;
	public float sphereRadius;
	// Use this for initialization
	void Start () {
		//test = this.gameObject;
	}
	private int RaysToShoot = 20;

	// Update is called once per frame
	void Update ()
	{
		/*float angle = 0;
		for (int i = 0; i < RaysToShoot; i++) {
			float x = Mathf.Tan (angle);
			float y = Mathf.Tan (angle);
			angle += 2 * Mathf.PI / RaysToShoot;

			Vector3 dir = new Vector3 (transform.position.x + x, transform.position.y + y, 0);
			RaycastHit hit;
			Debug.DrawLine (transform.position, dir, Color.red);
			if (Physics.Raycast (transform.position, dir, out hit) && hit.transform.tag == "Player") {
				Debug.Log ("Player is close");
				test.GetComponent<Renderer> ().material.color = new Color (0, 0,  hit.distance);
			} else {
				Debug.Log ("Player is far away");
			}
		}*/
	}
}
