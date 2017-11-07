using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower_Interaction : MonoBehaviour {
	public GameObject Player;
	public Animator m_Animator;
	public delegate void TriggerShader(Vector3 _pos);
	public static event TriggerShader Trigger_Shader; 
	public bool test;
	public static bool LeanFlower;
	void Start() {

		m_Animator = GetComponent<Animator> ();
	}

	void Update()
	{
		Vector3 toOther = Player.transform.position - transform.position;
		if (Vector3.Dot (transform.TransformDirection (transform.forward), toOther) < 0) {
			m_Animator.SetBool ("left", false);
			m_Animator.SetBool ("right", true);
			LeanFlower = false;
		}
		if (Vector3.Dot (transform.TransformDirection (transform.forward), toOther) > 0) {
			m_Animator.SetBool ("right", false);
			m_Animator.SetBool ("left", true);
			LeanFlower = true;
		}
	}

	public void FlowerInteraction()
	{
		if (!test) {
			test = true;
			Trigger_Shader (transform.position);
		}
	}

}
