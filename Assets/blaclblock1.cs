using UnityEngine;
using System.Collections;

public class blaclblock1 : MonoBehaviour {
	
	bool flag = false;
	bool trigger = false;
	float t = -1000;
	
	void OnCollisionEnter2D (Collision2D other){
		//if (other.gameObject.tag == "border") {
		if(!flag){
			flag = true;
			trigger = true;
		}
		if(flag&&!trigger)
		{
			flag = false;
		}
		trigger = false;
	}
	//}
	
	void Update(){
		if (!flag&&Time.time>t+0.5f) {
						GetComponent<Rigidbody2D>().velocity = transform.up * 2;
			t = Time.time;
				}
		if(flag&&Time.time>t+0.5f){
			GetComponent<Rigidbody2D>().velocity = -transform.up * 2;
			t = Time.time;
		}
	}
	
}