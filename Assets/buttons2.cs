using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class buttons2 : MonoBehaviour {


	public Text txt;




	void Start()
	{

		Debug.Log (PlayerPrefs.GetString ("CurLevel"));

		txt.text = "Level " + PlayerPrefs.GetString ("CurLevel");


	}




	public void Home()
	{
		Application.LoadLevel ("sd 2");
	}


	public void Reload()
	{
		Application.LoadLevel (PlayerPrefs.GetString ("CurLevel"));
	}



	public void ClickMusic()
	{
		if (PlayerPrefs.GetInt ("Sound") == 2) {

			GameObject.Find ("ClickAudio").GetComponent<AudioSource> ().Play ();

		}

	}
}
