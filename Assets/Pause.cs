using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject fader,cam,play,score1,score2,exit,next;
	bool flag = false;
	float spriteOpacity = 0;


	void Start(){
		fader = GameObject.Find ("Fader");
		cam = GameObject.Find ("Camera3");
		score1 = GameObject.Find ("Score1");
		score2 = GameObject.Find ("Score2");
		exit = GameObject.Find ("Exit");
		next = GameObject.Find ("Next level");
	
	}
	
	void Update(){
		int i = 0;
		while ((i<Input.touchCount&&!flag)) {
			if((GetComponent<Collider2D>().OverlapPoint(cam.GetComponent<Camera>().ScreenToWorldPoint(Input.GetTouch(i).position))
			    &&Input.GetTouch(i).phase==TouchPhase.Ended)){
				flag = true;
		}
			if (GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position)))
				GetComponent<Renderer>().material.color = new Color(0,1,0,1);
			if (!GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position)))
				GetComponent<Renderer>().material.color = new Color(1,1,1,1);
			i++;
		}

		if (!flag && GameObject.FindGameObjectsWithTag ("Player").Length < 2)
						flag = true;
//		if((collider2D.OverlapPoint(cam.camera.ScreenToWorldPoint(Input.mousePosition))&&Input.GetButtonDown("Fire1")&&!flag)||GameObject.FindGameObjectsWithTag("Player").Length < 2){
//			flag = true;
//		}	
		if (flag) {
			spriteOpacity = Mathf.MoveTowards(spriteOpacity,1,Time.deltaTime);
			fader.GetComponent<Renderer>().material.color = new Color(0,0,0,spriteOpacity);
			score1.GetComponent<TextMesh>().color = new Color(1,0,0,spriteOpacity);
			score2.GetComponent<TextMesh>().color = new Color(0,0,1,spriteOpacity);
			exit.GetComponent<TextMesh>().color = new Color(1,1,1,spriteOpacity);
			next.GetComponent<TextMesh>().color = new Color(1,1,1,spriteOpacity);

			if(spriteOpacity==1f)
			{
				Instantiate(play);
				Destroy(gameObject);
			}
		}

	}
}
