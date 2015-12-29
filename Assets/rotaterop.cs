using UnityEngine;
using System.Collections;

public class rotaterop : MonoBehaviour {

	void Update(){
		transform.Rotate (-transform.forward*Time.deltaTime*30);
	}
}
