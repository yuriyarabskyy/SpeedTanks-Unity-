using UnityEngine;
using System.Collections;

public class protect : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Finish"||other.gameObject.tag=="bullet") {
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}
