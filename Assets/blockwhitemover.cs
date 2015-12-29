using UnityEngine;
using System.Collections;

public class blockwhitemover : MonoBehaviour {



	void Update(){
		if (transform.position.y > 6.99f&&transform.position.y<7.01f&&transform.position.x<8.56f) {
			GetComponent<Rigidbody2D>().velocity = new Vector3(-1f,0,0);
				}
		if (transform.position.y < -6.99f&&transform.position.y>-7.01f&&transform.position.x>-8.56f) {
			GetComponent<Rigidbody2D>().velocity = new Vector3(1f,0,0);
				}
		if (transform.position.x > -8.56f&&transform.position.x<-8.54f&&transform.position.y>-6.99f) {
			GetComponent<Rigidbody2D>().velocity = new Vector3(0,-1f,0);
				}
		if (transform.position.x < 8.56f&&transform.position.x>8.54f&&transform.position.y<6.99f) {
			GetComponent<Rigidbody2D>().velocity = new Vector3(0,1f,0);
				}
	}

}
