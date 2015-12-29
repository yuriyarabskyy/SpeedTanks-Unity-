using UnityEngine;
using System.Collections;

public class shield2 : MonoBehaviour {

	GameObject player;
	
	void Start(){
		player=GameObject.Find ("PivotPont");
	}
	
	void Update(){
		transform.position = player.transform.position;
	}
}
