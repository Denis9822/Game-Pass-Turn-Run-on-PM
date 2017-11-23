using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {

	public float x,y;
	public bool mins;
	// Use this for initialization
	void Start () {
		mins = false;
		x = gameObject.transform.localScale.x;
		y = gameObject.transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.transform.localScale.x > 0 && gameObject.transform.localScale.y > 0 && mins == false)
			gameObject.transform.localScale = new Vector3 (gameObject.transform.localScale.x - Time.deltaTime + 0.01f, gameObject.transform.localScale.y - Time.deltaTime+ 0.01f, 1);

		
	

	}
}
