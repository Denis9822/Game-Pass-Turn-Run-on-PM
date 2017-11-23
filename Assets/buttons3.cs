using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class buttons3 : MonoBehaviour {


	public Text txt;

	public int a; 

	public static int b=10;

	void Start()
	{



		Debug.Log (b);
			


		if (b >= int.Parse (PlayerPrefs.GetString ("CurLevel"))+1 )
			a = int.Parse (PlayerPrefs.GetString ("CurLevel"))+1;
		else
			a = int.Parse (PlayerPrefs.GetString ("CurLevel"));


		PlayerPrefs.SetString ("CurLevel", a.ToString());

		txt.text = "Level " + PlayerPrefs.GetString ("CurLevel");


	}

	public void LoadScenedd()
	{
		Application.LoadLevel (PlayerPrefs.GetString ("CurLevel"));
	}


	public void Home()
	{
		Application.LoadLevel ("sd 2");
	}






	public void ClickMusic()
	{
		if (PlayerPrefs.GetInt ("Sound") == 2) {

			GameObject.Find ("ClickAudio").GetComponent<AudioSource> ().Play ();

		}

	}
}
