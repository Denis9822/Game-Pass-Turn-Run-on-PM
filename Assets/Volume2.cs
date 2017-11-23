using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume2 : MonoBehaviour {
	public GameObject musicOff;
	public GameObject music;
	public GameObject sound;
	public GameObject soundOff;
	// Use this for initialization
	void Start () {

		Debug.Log (PlayerPrefs.GetInt ("Music"));
		if (PlayerPrefs.GetInt ("Music") == 1) {
			music.SetActive (false);
			musicOff.SetActive (true);
		} 

		if (PlayerPrefs.GetInt ("Music") == 2) {
			musicOff.SetActive (false);
			music.SetActive (true);
		}


		if (PlayerPrefs.GetInt ("Sound") == 1) {
			sound.SetActive (false);
			soundOff.SetActive (true);
		} 

		if (PlayerPrefs.GetInt ("Sound") == 2) {
			soundOff.SetActive (false);
			sound.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
