using UnityEngine;
using System.Collections;

public class exitonea : MonoBehaviour {
	
	public GameObject cam;
	
	void Start(){
		GetComponent<Renderer>().sortingOrder = 7;
	}
	
	void Update(){
		int i = 0;
		while (i<Input.touchCount) {
			if (GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position))
			    && Input.GetTouch (i).phase == TouchPhase.Ended&&GetComponent<TextMesh>().color.a==1){
				PlayerPrefs.SetInt("score1",0);
				PlayerPrefs.SetInt("score2",0);
				PlayerPrefs.SetInt("scene1",0);
				PlayerPrefs.SetInt("scene2",0);
				PlayerPrefs.SetInt("scene3",0);
				PlayerPrefs.SetInt("scene4",0);
				PlayerPrefs.SetInt("scene5",0);
				PlayerPrefs.SetInt("scene6",0);
				Application.LoadLevel ("OneScreenArcade");
			}
			if (GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position))&&GetComponent<TextMesh>().color.a==1)
				GetComponent<Renderer>().material.color = new Color(0,1,0,1);
			if (!GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position))&&GetComponent<TextMesh>().color.a==1)
				GetComponent<Renderer>().material.color = new Color(1,1,1,1);
			i++;
		}
		
	}
}