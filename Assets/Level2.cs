﻿using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour {
	
	bool flag=false;
	
	void Update(){
		int i = 0;
		bool lol = true;
		while (i<Input.touchCount) {
			if (GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position))
			    && Input.GetTouch (i).phase == TouchPhase.Ended){
				bool trig=false;
				if(!flag){
					PlayerPrefs.SetInt("scene2",1);
					flag = true;
					GetComponent<Renderer>().material.color = new Color(0,0,1,1);
					trig = true;}
				if(flag&&!trig){
					PlayerPrefs.SetInt("scene2",0);
					flag = false;
					lol=false;
					GetComponent<Renderer>().material.color = new Color(1,1,1,1);
				}
			}
			if (GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position))&&!flag&&lol)
				GetComponent<Renderer>().material.color = new Color(0,0,1,1);
			if (!GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position))&&!flag&&lol)
				GetComponent<Renderer>().material.color = new Color(1,1,1,1);
			i++;
		}
		
	}
}
