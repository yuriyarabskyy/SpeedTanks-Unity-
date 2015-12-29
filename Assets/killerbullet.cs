using UnityEngine;
using System.Collections;

public class killerbullet : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "bullet" || (other.gameObject.tag == "enemy"&&other.isTrigger!=enabled)) {
						Destroy (other.gameObject);
						Destroy (gameObject);
				}
	}
	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
