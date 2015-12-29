using UnityEngine;
using System.Collections;

public class blackblock : MonoBehaviour {

	bool flag = false;
	bool trigger = false;

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
		if(!flag)
			GetComponent<Rigidbody2D>().velocity = transform.up * 2;
		if(flag)
			GetComponent<Rigidbody2D>().velocity = -transform.up * 2;
	}
	
}
