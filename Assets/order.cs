using UnityEngine;
using System.Collections;

public class order : MonoBehaviour {

	void Start(){
		GetComponent<Renderer>().sortingOrder = 4;
	}
}
