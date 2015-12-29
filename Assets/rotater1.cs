using UnityEngine;
using System.Collections;

public class rotater1 : MonoBehaviour {
	
	void Update(){
		transform.Rotate (-transform.forward*Time.deltaTime*40);
		transform.RotateAround (new Vector3 (0, 0, 0), transform.forward, 70*Time.deltaTime);
	}
	
}
