using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class camera : MonoBehaviour, IBeginDragHandler, IDragHandler {

	// ПЕРЕМЕННЫЕ
	public GameObject pers;
	public GameObject persbez;
	public Text txt;

	public bool swipeUp;
	public bool swipeLeft;
	public bool swipeRigth;
	public bool canSwipe;
	public bool canJump;
	public bool canRun;
	public bool canSit;
	public bool iSTiimer;
	public bool canDo;
	GameObject[] ArrayBlocks;
	public List<GameObject> EndMassBlocks = new List<GameObject> ();
	int count1=0;

	public float startTime;
	public float startTime1;
	public float sitTime;
	public float timeStart;


	public float speedJump;
	public float speedCross;
	public float speedRotation;

	public float rotateCount;
	public float rotateCount1;
	public float returnCount;

	public Quaternion a;
	public Quaternion b;


	//РЕАЛИЗАЦИЯ СВАЙПОВ
	public void OnDrag (PointerEventData eventData)
	{

	}


	public void OnBeginDrag (PointerEventData eventData)
	{


	
			
			if (Mathf.Abs (eventData.delta.x) > Mathf.Abs (eventData.delta.y)) {

				if (eventData.delta.x > 0) {    //Вправо свайп
					rotateCount += 90;
					swipeRigth = true;
					b = pers.transform.rotation;
					startTime1 = Time.timeSinceLevelLoad;
		
			
				} else {
		
					rotateCount -= 90;
					swipeLeft = true;
					a = pers.transform.rotation;
					startTime = Time.timeSinceLevelLoad;
				}

			} else {


				if (eventData.delta.y > 0 && canJump == true) {  //Вверх свайп
					swipeUp = true;
				}
			}

	
	/*	if (Mathf.Abs (eventData.delta.x) < Mathf.Abs (eventData.delta.y)) 

			if (eventData.delta.y < 0 && canSwipe == false) { 
				//canRun = false;
				//canSit = true;
			} else
				//canRun = true;

*/
		


	}





	void Start () {
		iSTiimer = true;
		timeStart = 0;
		pers.SetActive (false);
		canDo = false;
	

	/*	ArrayBlocks = GameObject.FindGameObjectsWithTag("stupen");

		for (int i = 0; i < ArrayBlocks.Length; i++) 
			EndMassBlocks.Add (ArrayBlocks [i]);

		EndMassBlocks.Reverse ();
	
*/

	}


	void Update () {

		if (iSTiimer == true) {
			timeStart += Time.deltaTime;
			if (timeStart < 1f)
				txt.text = 3.ToString ();
			else if (timeStart < 2f)
				txt.text = 2.ToString ();
			else if (timeStart < 3f)
				txt.text = 1.ToString ();
			else {
				canDo = true;
				canRun = true;
				Destroy (txt.gameObject);
		
				Destroy (persbez);
				pers.SetActive (true);
				iSTiimer = false;

			}
		}


		/*if (canSwipe == false) {
			swipeLeft = false;
			swipeRigth = false;

		}
*/

		/*if (pers.transform.eulerAngles.y < 0) {
			pers.transform.rotation = Quaternion.Euler (0, 0, 0);

			//Debug.Log (pers.transform.eulerAngles.y);
			swipeUp = false;
			swipeLeft = false;
			swipeRigth = false;
		}
		*/
		//Debug.Log (pers.transform.eulerAngles.y);
		//Debug.Log (Time.timeSinceLevelLoad);
		//Debug.Log (startTime);

		if (canDo == true) {
			if (swipeUp == true) {
				/*canRun = false;
			canSit = false;
				pers.transform.position = Vector3.MoveTowards (pers.transform.position, EndMassBlocks [count1].transform.position, speedJump * Time.deltaTime);

				if (pers.transform.position == EndMassBlocks [count1].transform.position) {

					count1++;
					swipeUp = false;
				canRun = true;

				}*/
			} else if (swipeRigth == true) {

				pers.transform.rotation = Quaternion.Lerp (b, Quaternion.Euler (0, rotateCount, 0), (Time.timeSinceLevelLoad - startTime1) * speedRotation);

		
				if (pers.transform.eulerAngles.y == 90f || pers.transform.eulerAngles.y == 180f || pers.transform.eulerAngles.y == 270f || pers.transform.eulerAngles.y == 360f) {
					swipeRigth = false;
				
					pers.transform.rotation = Quaternion.Euler (0, rotateCount + 1, 0);
			
				}

			} else if (swipeLeft == true) {

				//Debug.Log (Time.timeSinceLevelLoad);
				pers.transform.rotation = Quaternion.Lerp (a, Quaternion.Euler (0, rotateCount, 0), (Time.timeSinceLevelLoad - startTime) * speedRotation);

			


				if (pers.transform.eulerAngles.y == 90f || pers.transform.eulerAngles.y == 180f || pers.transform.eulerAngles.y == 270f || pers.transform.eulerAngles.y == 360f || pers.transform.eulerAngles.y == 1f) {
					swipeLeft = false;
	
					pers.transform.rotation = Quaternion.Euler (0, rotateCount + 1, 0);
			
				}

			}


		}

	}

	void FixedUpdate()
	{

		if (canDo == true) {

			if (canRun == true)
				pers.transform.Translate (Vector3.forward * Time.deltaTime * speedCross);
			/*else if (canSit == true) {
				pers.transform.Translate (Vector3.forward * Time.deltaTime * speedCross / 7);
				sitTime++;
				if (sitTime > 30) {
					canSit = false;
					canRun = true;
					sitTime = 0;
				}
			}*/
		}
	}

	//КУРИТИНКИ







}


