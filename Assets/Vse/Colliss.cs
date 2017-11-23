using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Colliss : MonoBehaviour {

	public bool isFall;

	public GameObject player;
	public GameObject rag;
	public Rigidbody rg;
	public Animator anims;
	public Animator anims2;
	public Text maxCnt;

	public float a;

	public int countMoney;
	public float speedCoin;
	public bool isMax;
	void Start()
	{
		GameObject.Find ("Music").GetComponent<AudioSource> ().volume = 0.05f;
		anims2 = GetComponent<Animator> ();
		rg = GetComponent<Rigidbody> ();
		maxCnt.text = PlayerPrefs.GetInt ("Score").ToString ();
		//Debug.Log (GameObject.Find ("Panel").GetComponent<camera>().speedJump=2f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//if (rg.velocity.y < 0)
			//Debug.Log ("falling");

		//Debug.Log (rg.velocity.y);



	}

	void Update()
	{






		if (isMax == true) {
			PlayerPrefs.SetInt ("Score", PlayerPrefs.GetInt ("Score") + countMoney);
			maxCnt.text = PlayerPrefs.GetInt ("Score").ToString ();
			isMax = false;
		}

	

		if (GameObject.Find ("Panel").GetComponent<camera> ().swipeUp == true)
			rg.useGravity = false;
		else if (a < 10) {
			
			//Debug.DrawRay (transform.position, -transform.up * 21f, Color.black);


			if (Physics.Raycast (transform.position, -transform.up, 21f)) {
				a = 0;
			} else {

				a += 1;
				Debug.Log (a);
			}
		} else {
			isFall = true;
			rg.useGravity = true;
		}


		if (isFall == true) {
			adsmy.AdsCount++;
			rag.SetActive (true);
			gameObject.SetActive (false);
		
			Instantiate (rag, player.transform.position, player.transform.rotation);



		} else if (GameObject.Find("StartScene") == null) {
			
			anims2.SetBool ("run", true);
		}

	}


	void OnCollisionEnter(Collision other)
	{
	/*	if (other.gameObject.tag == "rotateR")
			GameObject.Find ("Panel").GetComponent<camera> ().canSwipe = true;
		
		if (other.gameObject.tag == "rotateL")
			GameObject.Find ("Panel").GetComponent<camera> ().canSwipe = true;

		if (other.gameObject.tag == "jump") {
			GameObject.Find ("Panel").GetComponent<camera> ().canJump = true;
			GameObject.Find ("Panel").GetComponent<camera> ().canSwipe = true;
		}
*/
		if (other.gameObject.tag == "finish") {
			Application.LoadLevel("sd 3");
			GameObject.Find ("Panel").GetComponent<camera> ().iSTiimer = true;
		}
		}




	void OnCollisionExit(Collision other)
	{
	/*	if (other.gameObject.tag == "rotateL")
			GameObject.Find ("Panel").GetComponent<camera> ().canSwipe = false;
		
		if (other.gameObject.tag == "rotateR")
			GameObject.Find ("Panel").GetComponent<camera> ().canSwipe = false;
		if (other.gameObject.tag == "jump") {
			GameObject.Find ("Panel").GetComponent<camera> ().canJump = false;
			GameObject.Find ("Panel").GetComponent<camera> ().canSwipe = false;
		}
*/
	}

	void OnCollisionStay(Collision other)
	{
		
	}


	void OnTriggerEnter(Collider other)
	{
			if (other.gameObject.tag == "money") {
			Debug.Log ("asdas");

			other.GetComponentInParent<transofrmCoin> ().isColli = true;

			//Destroy (other.transform.parent.gameObject);
			//Destroy (other.gameObject.transform.parent);
			countMoney++;
			isMax = true;

		}

	}






}

