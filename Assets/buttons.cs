using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Advertisements;

public class buttons : MonoBehaviour {

	public GameObject panelMenu;
	public GameObject LevelShow;
	public GameObject level;
	public GameObject levels;




	public Text money;
	public Text leveltxt;

		void Start()
		{

		GameObject.Find ("Music").GetComponent<AudioSource> ().Play ();

		if (PlayerPrefs.GetInt ("Music") == 0)
			PlayerPrefs.SetInt("Music",1) ;

		if (PlayerPrefs.GetInt ("Sound") == 0)
			PlayerPrefs.SetInt("Sound",1) ;


		if (PlayerPrefs.GetString ("CurLevel") == "")
			PlayerPrefs.SetString ("CurLevel","1") ;

		if (PlayerPrefs.GetString ("MaxLevel") == "")
			PlayerPrefs.SetString ("MaxLevel","1") ;

		if (int.Parse(PlayerPrefs.GetString ("MaxLevel")) < int.Parse(PlayerPrefs.GetString ("CurLevel"))) 
			PlayerPrefs.SetString ("MaxLevel", PlayerPrefs.GetString ("CurLevel"));

	



		leveltxt.text = "Level " +  PlayerPrefs.GetString ("CurLevel");


	}

	void Update()
	{
		money.text = PlayerPrefs.GetInt ("Score").ToString ();
		if (PlayerPrefs.GetInt ("Music") == 2) {

			GameObject.Find ("Music").GetComponent<AudioSource> ().volume = 0.2f;
	
		} else {
			GameObject.Find ("Music").GetComponent<AudioSource> ().volume = 0f;

		}

	}
	public void LoadScenedd()
	{
		Application.LoadLevel (PlayerPrefs.GetString ("CurLevel"));
	}

	public void Menus(string stan)
	{
		
		if (panelMenu.activeSelf == false) {
			panelMenu.SetActive (true);
			level.SetActive (false);
			levels.SetActive (false);
		} else {
			panelMenu.SetActive (false);	
			level.SetActive (true);
			levels.SetActive (true);
		}

	}

	public void ClickMusic()
	{
		if (PlayerPrefs.GetInt ("Sound") == 2) {

			GameObject.Find ("ClickAudio").GetComponent<AudioSource> ().Play ();

		}

	}


	public void LoadLevel()
	{

		if (LevelShow.activeSelf==false)
		LevelShow.SetActive (true);
		else
			LevelShow.SetActive (false);	

	}


	public void setLevel(string levelq)
	{

		if ((int.Parse (levelq) == int.Parse (PlayerPrefs.GetString ("CurLevel"))) || (int.Parse (levelq) < int.Parse (PlayerPrefs.GetString ("MaxLevel")))) {

			PlayerPrefs.SetString ("CurLevel", levelq);


			
			leveltxt.text = "Level " + PlayerPrefs.GetString ("CurLevel");
			LevelShow.SetActive (false);
		}


	}

	public void ShowVideo()
	{

		if (Advertisement.isSupported) {
			Advertisement.Initialize ("1552300",false);


		} else {
			Debug.Log ("НЕТ РЕКЛАПМЫ");
		}




		StartCoroutine ("ShowADS");


			


	}



	IEnumerator ShowADS(){

		yield return new WaitForSeconds (0.5f);
		while (!Advertisement.IsReady ())
			yield return null;
		Advertisement.Show ();
		PlayerPrefs.SetInt ("Score", PlayerPrefs.GetInt ("Score") + 10);
	}

}
