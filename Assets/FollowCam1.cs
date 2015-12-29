using UnityEngine;
using System.Collections;

public class FollowCam1 : MonoBehaviour {
	
	public GameObject player;
	
	void Update(){
		transform.position = player.transform.position;
		transform.position = new Vector3 (transform.position.x+1, transform.position.y, -10);
	}
}