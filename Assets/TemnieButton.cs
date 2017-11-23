using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemnieButton : MonoBehaviour {

	//List<GameObject> arr = new List<GameObject>();

	public GameObject [] arr;
	public Color clr;

	void Start () {



		arr = GameObject.FindGameObjectsWithTag ("level");


		for (int i = 0; i < arr.Length; i++) {

			if (int.Parse (arr [i].name) > int.Parse (PlayerPrefs.GetString ("MaxLevel"))) {
				arr[i].GetComponent<Image>().color = clr;
	
			
		
				//arr[i].GetComponentInChildren<RectTransform>().gameObject.SetActive(true);
			}
				
		
	

		}

		PlayerPrefs.SetInt ("CountLVL",arr.Length);

	}
	

}
