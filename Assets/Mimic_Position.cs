using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mimic_Position : MonoBehaviour {
	public GameObject CenterEye;
	// Update is called once per frame
	void Update () {
		if (Flower_Interaction.LeanFlower) {
			if (CenterEye.transform.eulerAngles.z > 20 && CenterEye.transform.eulerAngles.z < 200)
				Debug.Log ("LEAN INTO FLOWER L");
		}
		if (!Flower_Interaction.LeanFlower) {
			if (CenterEye.transform.eulerAngles.z > 200 && CenterEye.transform.eulerAngles.z < 300)
				Debug.Log ("LEAN INTO FLOWER R");
		} else {
			Debug.Log ("LEAN INTO FLOWER R");
		}
	}
}
