using UnityEngine;
using System.Collections;

public class protector : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Finish") {
			Debug.Log("YES");
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}
