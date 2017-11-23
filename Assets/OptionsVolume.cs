using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsVolume : MonoBehaviour {
	public GameObject music;
	public GameObject musicOff;
	public GameObject sound;
	public GameObject soundOff;


	void Start()
	{


	
	}

	public void Music()
	{

			musicOff.SetActive (true);
			music.SetActive (false);
			PlayerPrefs.SetInt ("Music", 1);


	

	}
	public void MusicOff()
	{


			music.SetActive (true);
			musicOff.SetActive (false);
			PlayerPrefs.SetInt ("Music", 2);



	}





	public void Sound()
	{
		
		soundOff.SetActive (true);
		sound.SetActive (false);
		PlayerPrefs.SetInt ("Sound", 1);


	}
	public void SoundOff()
	{
			sound.SetActive (true);
			soundOff.SetActive (false);
			PlayerPrefs.SetInt ("Sound", 2);
	}


}
