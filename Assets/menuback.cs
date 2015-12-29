using UnityEngine;
using System.Collections;

public class menuback : MonoBehaviour {

	public GameObject cam;
	
	void Start(){
		GetComponent<Renderer>().sortingOrder = 7;
	}
	
	void Update(){
		int i = 0;
		while (i<Input.touchCount) {
			if (GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position))
			    && Input.GetTouch (i).phase == TouchPhase.Ended&&GetComponent<TextMesh>().color.a==1){
				Application.LoadLevel ("Main12");
				Time.timeScale = 1;
			}
			if (GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position)))
				GetComponent<TextMesh>().color = new Color(0,1,0,1);
			if (!GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position)))
				GetComponent<TextMesh>().color = new Color(0,0,0,1);
			i++;
		}
		
	}
}
