using UnityEngine;
using System.Collections;

public class speedup : MonoBehaviour {
	public GameObject speeding1,speeding2;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player1") {
			if(GameObject.FindGameObjectWithTag("speeding1")==null)
				speeduper();
			if(GameObject.FindGameObjectWithTag("speeding1")!=null){
				speeduper();
			}
			Destroy(gameObject);
		}

		if (other.gameObject.name == "Player2") {
			if(GameObject.FindGameObjectWithTag("speeding2")==null)
				speeduper2();
			if(GameObject.FindGameObjectWithTag("speeding2")!=null){
				speeduper2();
			}
			Destroy(gameObject);
		}
	}

	void speeduper(){
		Destroy (GameObject.FindGameObjectWithTag ("speeding1"));
		Instantiate (speeding1);

	}
	void speeduper2(){
		Destroy (GameObject.FindGameObjectWithTag ("speeding2"));
	
		Instantiate (speeding2);
		
	}
}
