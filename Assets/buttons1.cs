using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class buttons1 : MonoBehaviour {

	public GameObject panelMenu;


	int a; 


	void Start()
	{






	}

	public void LoadScenedd()
	{
		Application.LoadLevel (PlayerPrefs.GetString ("CurLevel"));
	}


	public void Home()
	{
		Application.LoadLevel ("sd 2");
	}




	public void Menus(string stan)
	{
		
		if (panelMenu.activeSelf == false) {
			panelMenu.SetActive (true);
	
		} else {
			panelMenu.SetActive (false);	
		
		}

	}

	public void ClickMusic()
	{
		if (PlayerPrefs.GetInt ("Sound") == 2) {

			GameObject.Find ("ClickAudio").GetComponent<AudioSource> ().Play ();

		}

	}
}
