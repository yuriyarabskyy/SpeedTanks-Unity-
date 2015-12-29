using UnityEngine;
using System.Collections;

public class dulo : MonoBehaviour {

	public GameObject player;

	void Update(){
		transform.position = player.transform.position; //+ new Vector3 (0.44999f, 0.155f, 0);
	}
}
