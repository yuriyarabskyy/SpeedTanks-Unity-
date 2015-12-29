using UnityEngine;
using System.Collections;

public class splscrc : MonoBehaviour {
	void Update(){
				int i = 0;
				while (i<Input.touchCount&&GetComponent<TextMesh>().color.a==1) {
						if (GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position))
								&& Input.GetTouch (i).phase == TouchPhase.Ended) {
				Application.LoadLevel("Main2");
						}
						if (GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position)))
								GetComponent<Renderer>().material.color = new Color (0, 1, 0, 1);
						if (!GetComponent<Collider2D>().OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position)))
								GetComponent<Renderer>().material.color = new Color (1, 1, 1, 1);
						i++;
				}
		}
}
