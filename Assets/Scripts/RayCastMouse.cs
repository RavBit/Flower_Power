using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastMouse : MonoBehaviour {
    Vector3 _mousePos, _smoothPoint;
    public float _radius, _softness, _smoothSpeed, _scaleFactor;
	// Use this for initialization
	void Start () {
		Flower_Interaction.Trigger_Shader += RemoveColours;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)) {
            _radius += _scaleFactor * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            _radius -= _scaleFactor * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            _softness += _scaleFactor * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            _softness += _scaleFactor * Time.deltaTime;
        }
        Mathf.Clamp(_radius, 0, 100);
        Mathf.Clamp(_softness, 0, 100);
        Vector4 pos = new Vector4(-2.86f, -1.49f, 1.26f, 0);
        Shader.SetGlobalVector("GLOBALmask_Position", pos);
        Shader.SetGlobalFloat("GLOBALmask_Radius", _radius);
        Shader.SetGlobalFloat("GLOBALmask_Softness", _softness);
    }

	void RemoveColours(Vector3 _pos)
	{
		Shader.SetGlobalVector("GLOBALmask_Position", _pos);
		StartCoroutine("RemoveColoursInTime", 10);
	}

	IEnumerator RemoveColoursInTime(float time)
	{
		while (time > 0) {
			Debug.Log ("Time " + time);
			Debug.Log ("Shader: " + Shader.GetGlobalFloat ("GLOBALmask_Radius"));
			time = time -0.05f;
			_radius = time;
			yield return new WaitForSeconds (0.05f);
		}

	}

}
