using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {
	public GameObject play,cam;

	void Update(){
		//if (GameObject.FindGameObjectsWithTag("Player").Length < 2)
		//		if (Input.GetTouch (0).phase == TouchPhase.Ended&&
		//	    play.collider2D.OverlapPoint(cam.camera.ScreenToWorldPoint(Input.GetTouch(0).position)))
		if (GameObject.FindGameObjectsWithTag("Player").Length < 2)
			if(Input.GetButtonDown("Fire1")&&play.GetComponent<Collider2D>().OverlapPoint(cam.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition)))
						Application.LoadLevel (Application.loadedLevel);

	}
	

}
