using UnityEngine;
using System.Collections;

public class restartsingle : MonoBehaviour {

	public GameObject cam;
	bool flag = true,trigger = false;
	float spriteOpacity = 0;
	
	void Start(){
		GetComponent<Renderer>().sortingOrder = 7;
		GetComponent<TextMesh> ().color = new Color (0, 0, 0, 0);
		GetComponent<BoxCollider2D> ().enabled = false;
	}
	
	void Update(){
		if (GameObject.FindGameObjectWithTag ("Player") == null&&flag) {
			trigger = true;
			GetComponent<BoxCollider2D> ().enabled = true;
			flag = false;
				}
		if (trigger) {
			spriteOpacity = Mathf.MoveTowards(spriteOpacity,1,Time.deltaTime);
			GetComponent<TextMesh> ().color = new Color (0, 0, 0, spriteOpacity);
				}
		int i = 0;
		while (i<Input.touchCount&&GetComponent<BoxCollider2D> ().enabled==true) {
			if (GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position))
			    && Input.GetTouch (i).phase == TouchPhase.Ended&&GetComponent<TextMesh>().color.a==1){
				Application.LoadLevel (Application.loadedLevel);
			}
			if (GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position)))
				GetComponent<TextMesh>().color = new Color(0,1,0,1);
			if (!GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position)))
				GetComponent<TextMesh>().color = new Color(0,0,0,1);
			i++;
		}
		
	}
}
