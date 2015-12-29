using UnityEngine;
using System.Collections;

public class DestroyA : MonoBehaviour {
	Vector2 startpos;
	public GameObject flag1,flag2;

	void Start(){
		startpos = GameObject.Find ("startpos").transform.position;
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "Player2") {
			other.gameObject.transform.position = new Vector3(startpos.y,0,0);
			if(GameObject.FindGameObjectWithTag("flag2")!=null){
				Destroy(GameObject.FindGameObjectWithTag("flag2"));

			}
			if(GameObject.FindGameObjectWithTag("flag1")==null)
				Instantiate(flag1);
		}
		if (other.gameObject.name == "Player1") {
			other.gameObject.transform.position = new Vector3(startpos.x,0,0);
			if(GameObject.FindGameObjectWithTag("flag1")!=null){
				Destroy(GameObject.FindGameObjectWithTag("flag1"));
			}
			if(GameObject.FindGameObjectWithTag("flag2")==null)
				Instantiate(flag2);
		}
		Destroy (gameObject);
	}


}
