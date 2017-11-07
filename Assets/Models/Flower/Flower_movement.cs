using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower_movement : MonoBehaviour {

	public Animator m_animator;

	// Use this for initialization
	void Start () {
		m_animator = gameObject.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
	//Left movement

		if (Input.GetKeyDown (KeyCode.A))
			m_animator.SetBool ("left", true);
		if (Input.GetKeyUp (KeyCode.A))
			m_animator.SetBool ("left", false);
	//Right movement

		if (Input.GetKeyDown (KeyCode.D))
			m_animator.SetBool ("right", true);
		if (Input.GetKeyUp (KeyCode.D))
			m_animator.SetBool ("right", false);
	//Back movement

		if (Input.GetKeyDown (KeyCode.W))
			m_animator.SetBool ("back", true);
		if (Input.GetKeyUp (KeyCode.W))
			m_animator.SetBool ("back", false);


	
			
		
	}
}
