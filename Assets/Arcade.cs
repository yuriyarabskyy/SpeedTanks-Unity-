using UnityEngine;
using System.Collections;

public class Arcade : MonoBehaviour {
	bool flag = false,lol=false,trigger=true,trig=false;
	public GameObject spl,one;
	float spriteOpacity;
	
	void Start(){
		spriteOpacity = 0;
	}
	
	void Update(){
		int i = 0;
		trig = false;
		while (i<Input.touchCount) {
			if (GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position))
			    && Input.GetTouch (i).phase == TouchPhase.Ended) {
				PlayerPrefs.SetInt ("scene1", 0);
				PlayerPrefs.SetInt ("scene2", 0);
				PlayerPrefs.SetInt ("scene3", 0);
				PlayerPrefs.SetInt ("scene4", 0);
				PlayerPrefs.SetInt ("scene5", 0);
				PlayerPrefs.SetInt ("scene6", 0);
				flag = true;
				trigger = true;
				if(!lol){
					lol = true;
					trigger = false;
				}
				if(lol&&trigger)
					lol=false;
				if(lol)
					GetComponent<Renderer>().material.color = new Color (0, 1, 0, 1);
				if(!lol){
					GetComponent<Renderer>().material.color = new Color (1, 1, 1, 1);
					trig = true;
				}
			}
			if (GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position))&&!lol&&!trig)
				GetComponent<Renderer>().material.color = new Color (0, 1, 0, 1);
			if (!GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position))&&!lol&&!trig)
				GetComponent<Renderer>().material.color = new Color (1, 1, 1, 1);
			i++;
		}
		
		if (flag&&lol) {
			spriteOpacity = Mathf.MoveTowards(spriteOpacity,1,Time.deltaTime);
			spl.GetComponent<TextMesh>().color = new Color(1,1,1,spriteOpacity);
			one.GetComponent<TextMesh>().color = new Color(1,1,1,spriteOpacity);
			if(spriteOpacity==1){
				flag = false;
			}
		}
		if (!lol&&spriteOpacity>0) {
			spriteOpacity = Mathf.MoveTowards(spriteOpacity,0,Time.deltaTime);
			spl.GetComponent<TextMesh>().color = new Color(1,1,1,spriteOpacity);
			one.GetComponent<TextMesh>().color = new Color(1,1,1,spriteOpacity);
		}
		
		
	}
	
}