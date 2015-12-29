using UnityEngine;
using System.Collections;

public class enemybullet : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			bool flag = true;
			if(GameObject.FindGameObjectWithTag("Life21")){
				Destroy(GameObject.FindGameObjectWithTag("Life21"));
				flag = false;
			}
			if(GameObject.FindGameObjectWithTag("Life22")&&flag){
				Destroy(GameObject.FindGameObjectWithTag("Life22"));
				flag = false;
			}
			if(GameObject.FindGameObjectWithTag("Life23")&&flag){
				Destroy(GameObject.FindGameObjectWithTag("Life23"));
				Destroy(other.gameObject);
			}
			Destroy (gameObject);
		}
	}
	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
