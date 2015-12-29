using UnityEngine;
using System.Collections;

public class scroller : MonoBehaviour {
	float spriteOpacity1,spriteOpacity2;
	bool flag,lol;
	public GameObject back;

	void Start(){
		flag = false;
		lol = false;
		spriteOpacity1 = 1;
		spriteOpacity2 = 0;
		back.GetComponent<BoxCollider2D> ().enabled = false;
	}

	void Update(){
		int j = 0;
		while (j<Input.touchCount) {
						if (GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (j).position))
								&& Input.GetTouch (j).phase == TouchPhase.Ended) {
								flag = true;
								lol = true;
				GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1);
				back.GetComponent<BoxCollider2D> ().enabled = true;
				GetComponent<BoxCollider2D> ().enabled = false;
						}
						if (Input.GetTouch (j).phase == TouchPhase.Began)
								lol = false;
						if (GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (j).position)) && !lol)
								GetComponent<SpriteRenderer> ().color = new Color (0, 1, 0, 1);
						if (!GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (j).position)))
								GetComponent<SpriteRenderer> ().color = new Color (1, 1, 1, 1);
			j++;
				}
		if (flag) {
			GameObject[] scr1 = GameObject.FindGameObjectsWithTag("twoscreenfirst");
			GameObject[] scr2 = GameObject.FindGameObjectsWithTag("twoscreensec");
			int i,k;
			spriteOpacity1 = Mathf.MoveTowards(spriteOpacity1,0,Time.deltaTime);
			spriteOpacity2 = Mathf.MoveTowards(spriteOpacity2,1,Time.deltaTime);
			for(k=0;k<scr2.Length;k++){
				scr2[k].GetComponent<SpriteRenderer>().color = new Color(scr2[k].GetComponent<SpriteRenderer>().color.r,scr2[k].GetComponent<SpriteRenderer>().color.g,scr2[k].GetComponent<SpriteRenderer>().color.b,spriteOpacity2);
			}
			for(i=0;i<scr1.Length;i++){
				scr1[i].GetComponent<SpriteRenderer>().color = new Color(scr1[i].GetComponent<SpriteRenderer>().color.r,scr1[i].GetComponent<SpriteRenderer>().color.g,scr1[i].GetComponent<SpriteRenderer>().color.b,spriteOpacity1);
			}
			if(spriteOpacity2==1)
				flag = false;

				}
		if (!flag) {
			spriteOpacity1 = 1;
			spriteOpacity2 = 0;
		}
	}
}
