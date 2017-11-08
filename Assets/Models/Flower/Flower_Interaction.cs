using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower_Interaction : MonoBehaviour {
	//public GameObject Left;
	public GameObject Bowl;
	public GameObject Player;
	public Animator m_Animator;
	public delegate void TriggerShader(Vector3 _pos);
	public static event TriggerShader Trigger_Shader; 
	public bool test;
	public static bool LeanFlower;
	void Start() {

		m_Animator = GetComponent<Animator> ();
	}
		


	/*void Update()
	{
		//float left = Vector3.Distance(Player.transform.position, Left.transform.position);
		//float right = Vector3.Distance (Player.transform.position, Right.transform.position);




		Vector3 toOther = Player.transform.position - Bowl.transform.position;
		if (Vector3.Dot (Bowl.transform.TransformDirection (Bowl.transform.right), toOther) < 0 && m_Animator.GetBool("right") == false) {
			Debug.Log ("Player behind you");
			m_Animator.SetBool ("left", false);
			m_Animator.SetBool ("right", true);
			LeanFlower = false;
		}
		if (Vector3.Dot (Bowl.transform.TransformDirection (Bowl.transform.right), toOther) > 0 && m_Animator.GetBool("left") == false) {
			Debug.Log ("Player in front of you");
			m_Animator.SetBool ("right", false);
			m_Animator.SetBool ("left", true);
			LeanFlower = true;
		}
	}*/

	public void FlowerInteraction()
	{
		if (!test) {
			test = true;
			Trigger_Shader (Bowl.transform.position);
		}
	}

}
