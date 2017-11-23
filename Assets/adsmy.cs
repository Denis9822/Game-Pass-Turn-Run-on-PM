using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class adsmy : MonoBehaviour {
	private bool iSAds;
	public static int AdsCount = 0;
	// Use this for initialization
	void Start () {
		iSAds = true;
		if (Advertisement.isSupported) {
			Advertisement.Initialize ("1552300",false);


		} else {
			Application.LoadLevel ("sd 4");
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("raggdol(Clone)")) {

			GameObject.Find ("Panel").GetComponent<camera> ().iSTiimer = true;
			StartCoroutine ("ShowADS");
			StartCoroutine ("ShowADS1");
	
		}
	}

	IEnumerator ShowADS(){
		yield return new WaitForSeconds (1.2f);
		if (AdsCount % 3 == 0) {
			AdsCount = 0;
			while (!Advertisement.IsReady ()) {
				iSAds = false;
				yield return null;
			}
			iSAds = true;
			Advertisement.Show ();
			Application.LoadLevel ("sd 4");
		} else {
			iSAds = false;
		}
			
	
	}

	IEnumerator ShowADS1(){
		yield return new WaitForSeconds (1.3f);
		if (iSAds == false) {
			Application.LoadLevel ("sd 4");
		}

	}

}
