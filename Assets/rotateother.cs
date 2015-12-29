using UnityEngine;
using System.Collections;

public class rotateother : MonoBehaviour {
	void Update(){
		transform.Rotate (-transform.forward*Time.deltaTime*30);
	}
}
