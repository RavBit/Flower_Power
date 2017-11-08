using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastMouse : MonoBehaviour {
	public GameObject POS;
    Vector3 _mousePos, _smoothPoint;
    public float _radius, _softness, _smoothSpeed, _scaleFactor;
	// Use this for initialization
	void Start () {
		Flower_Interaction.Trigger_Shader += RemoveColours;
		Flower_Interaction.G_Trigger_Shader += GoGray;
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
		Shader.SetGlobalVector("GLOBALmask_Position", POS.transform.position);
        Shader.SetGlobalFloat("GLOBALmask_Radius", _radius);
        Shader.SetGlobalFloat("GLOBALmask_Softness", _softness);

    }

	void RemoveColours(Vector3 _pos, float _strongness)
	{
		Debug.Log ("Test1");
		_radius = 10;
		Shader.SetGlobalFloat("GLOBALmask_Radius", _radius);
		Shader.SetGlobalFloat("GLOBALmask_Strongness", _strongness);
		Shader.SetGlobalVector("GLOBALmask_Position", POS.transform.position);
		StartCoroutine("RemoveColoursInTime", 10);
	}
	void GoGray(Vector3 _pos, float _strongness)
	{
		_radius = 0;
		Shader.SetGlobalFloat("GLOBALmask_Strongness", _strongness);
		Shader.SetGlobalVector("GLOBALmask_Position", POS.transform.position);
	}

	IEnumerator RemoveColoursInTime(float time)
	{
		Debug.Log ("Test");
		while (time > 0) {
			Debug.Log ("Time " + time);
			Debug.Log ("Strongness: " + Shader.GetGlobalFloat("GLOBALmask_Strongness"));
			//Debug.Log ("Shader: " + Shader.GetGlobalFloat ("GLOBALmask_Radius"));
			time = time -0.05f;
			_radius = time;
			yield return new WaitForSeconds (0.05f);
		}

	}

}
