using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects_Manager : MonoBehaviour {
	public Flower_Interaction Interaction;
	public AudioSource ThunderSound;
	public AudioSource Sunny;
	public AudioSource Rain;
	public GameObject RainParticle;
	public GameObject ThunderFlash;
	public GameObject SunnyLight;
	public AudioSource WindSound;
	void Start()
	{
		Rain.Play ();
		RainParticle.gameObject.SetActive (true);
	}
	void Update()
	{
		if (Input.GetKeyDown ("4")) {
			StopSunny ();
			Interaction.FlowerInteraction(0f);
			Invoke ("WindSoundStart", 8);
			Invoke ("StopAllSounds", 12);
			Debug.Log ("Trigger Grayscale");
		}
		if (Input.GetKeyDown ("3")) {
			StopSunny ();
			Rain.Play ();
			RainParticle.gameObject.SetActive (true);
			Debug.Log ("Trigger Rain");
		}
		if (Input.GetKeyDown ("1")){
			StopSound ();
			StopRain ();
			Sunny.Play ();
			SunnyLight.SetActive (true);
			Debug.Log ("Trigger sunny");
		}
		if (Input.GetKeyDown ("2")) {
			StopSunny ();
			StopSound ();
			StartCoroutine ("Thunder");
			ThunderSound.Play ();
			Debug.Log ("Trigger Storm");
		}

	}
	void StopSound()
	{
		ThunderSound.Stop ();
		Sunny.Stop ();
	}
	void StopAllSounds()
	{
		StopSound ();
		StopRain ();
	}
	void WindSoundStart()
	{
		WindSound.Play ();
	}
	void StopRain()
	{
		Rain.Stop ();
		RainParticle.gameObject.SetActive (false);
	}
	void StopSunny()
	{
		SunnyLight.SetActive (false);
	}
	IEnumerator Thunder()
	{
		ThunderFlash.SetActive (true);
		yield return new WaitForSeconds (0.01f);
		ThunderFlash.SetActive (false);
		StopCoroutine ("Thunder");
	}
}
