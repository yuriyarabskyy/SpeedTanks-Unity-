using UnityEngine;
using System.Collections;

public class rotater : MonoBehaviour {

	void Update(){
		transform.Rotate (transform.forward*Time.deltaTime*30);
	}

}
