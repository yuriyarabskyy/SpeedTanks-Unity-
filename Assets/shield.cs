using UnityEngine;
using System.Collections;

public class shield : MonoBehaviour {

	 GameObject player;

	void Start(){
		player=GameObject.Find ("PivotPoint");
	}

	void Update(){
		transform.position = player.transform.position;
	}
}
