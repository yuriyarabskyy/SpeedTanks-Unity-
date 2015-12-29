using UnityEngine;
using System.Collections;

public class Goonea : MonoBehaviour {

	void Update(){
		int i = 0;
		while (i<Input.touchCount) {
			if (GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position))
			    && Input.GetTouch (i).phase == TouchPhase.Ended){
				PlayerPrefs.SetInt("Score1",0);
				PlayerPrefs.SetInt("Score2",0);
				bool flag=false;
				if(PlayerPrefs.GetInt("scene1")==1&&!flag){
					PlayerPrefs.SetInt("scene1",2);
					flag = true;
					Application.LoadLevel("OneLevel1a");}
				if(PlayerPrefs.GetInt("scene2")==1&&!flag){
					PlayerPrefs.SetInt("scene2",2);
					flag = true;
					Application.LoadLevel("OneLevel2a");}
				if(PlayerPrefs.GetInt("scene3")==1&&!flag){
					PlayerPrefs.SetInt("scene3",2);
					flag = true;
					Application.LoadLevel("OneLevel3a");}
				if(PlayerPrefs.GetInt("scene4")==1&&!flag){
					PlayerPrefs.SetInt("scene4",2);
					flag = true;
					Application.LoadLevel("OneLevel4a");}
				if(PlayerPrefs.GetInt("scene5")==1&&!flag){
					PlayerPrefs.SetInt("scene5",2);
					flag = true;
					Application.LoadLevel("OneLevel5a");}
				if(PlayerPrefs.GetInt("scene6")==1&&!flag){
					PlayerPrefs.SetInt("scene6",2);
					flag = true;
					Application.LoadLevel("OneLevel6a");}
			}
			if (GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position)))
				GetComponent<Renderer>().material.color = new Color(0,1,0,1);
			if (!GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position)))
				GetComponent<Renderer>().material.color = new Color(1,1,1,1);
			i++;
		}
		
	}
}
