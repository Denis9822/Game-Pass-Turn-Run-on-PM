using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transofrmCoin : MonoBehaviour {

	public float speed;
	public bool isColli;
	// Update is called once per frame
	void Update () {

		if (isColli == true) {
			transform.Translate (Vector3.up * Time.deltaTime * speed);

			StartCoroutine (destCoin ());
		} else {


		}

	}


	IEnumerator destCoin(){

		yield return new WaitForSeconds (2f);

		Destroy (gameObject);


	}



}
