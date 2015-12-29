using UnityEngine;
using System.Collections;

public class shooterbon : MonoBehaviour {
	public GameObject shooting1,shooting2;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player1") {
			if(GameObject.FindGameObjectWithTag("shooting1")==null)
				shootinger();
			if(GameObject.FindGameObjectWithTag("shooting1")!=null){
				shootinger();
			}
			Destroy(gameObject);
		}
		
		if (other.gameObject.name == "Player2") {
			if(GameObject.FindGameObjectWithTag("shooting1")==null)
				shootinger2();
			if(GameObject.FindGameObjectWithTag("shooting1")!=null){
				shootinger2();
			}
			Destroy(gameObject);
		}
	}
	
	void shootinger(){
		Destroy (GameObject.FindGameObjectWithTag ("shooting1"));
		Instantiate (shooting1);
		
	}
	void shootinger2(){
		Destroy (GameObject.FindGameObjectWithTag ("shooting2"));
		
		Instantiate (shooting2);
		
	}
}