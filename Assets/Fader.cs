using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {
	
	float spriteOpacity;
	bool flag = false;
	
	void Start(){
		spriteOpacity = 1;
	}
	void Update(){
		if (!flag) {
						spriteOpacity = Mathf.MoveTowards (spriteOpacity, 0, Time.deltaTime);
						gameObject.GetComponent<Renderer>().material.color = new Color (0, 0, 0, spriteOpacity);
				}
		if (spriteOpacity == 0)
						flag = true;
	}
	
	
}