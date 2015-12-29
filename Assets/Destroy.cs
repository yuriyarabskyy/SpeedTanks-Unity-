using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	public GameObject life1,life2,life3;
	bool flag = false;

	void Start(){
		life1 = GameObject.FindGameObjectWithTag ("Life11");
		life2 = GameObject.FindGameObjectWithTag ("Life12");
		life3 = GameObject.FindGameObjectWithTag ("Life13");
	}

	void OnCollisionEnter2D(Collision2D other){
				if (other.gameObject.tag == "Player") {
						if (life1 != null) {
								Destroy (life1);
								Destroy (gameObject);
								flag = true;
						}
						if (life2 != null&&!flag) {
								Destroy (life2);
								Destroy (gameObject);
								flag = true;
						}
						if (life3 != null&&!flag) {
								Destroy (life3);
								Destroy (other.gameObject);
								Destroy (gameObject);
						}
				}
		Destroy (gameObject);
	}
	
	void OnBecameInvisible(){
		Destroy (gameObject);
	}	
}
