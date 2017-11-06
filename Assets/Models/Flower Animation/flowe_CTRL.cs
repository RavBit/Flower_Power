using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowe_CTRL : MonoBehaviour {

	public Animator m_Animator;


	// Use this for initialization
	void Start () {
		m_Animator = gameObject.GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A))
			m_Animator.SetBool ("left", true);
		if (Input.GetKeyUp (KeyCode.A))
			m_Animator.SetBool ("left", false);
	 
		

		if (Input.GetKeyDown (KeyCode.D))
			m_Animator.SetBool ("right", true);
		if (Input.GetKeyUp (KeyCode.D))
			m_Animator.SetBool ("right", false);
		
	}
}
