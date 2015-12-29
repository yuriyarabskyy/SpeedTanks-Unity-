using UnityEngine;
using System.Collections;

public class rot : MonoBehaviour {

	void Update(){
		if (GameObject.Find ("PivotPoint").transform.position == transform.position)
						transform.eulerAngles = GameObject.Find ("Player1").transform.eulerAngles;
		if (GameObject.Find ("PivotPont").transform.position == transform.position)
			transform.eulerAngles = GameObject.Find ("Player2").transform.eulerAngles;
	}

}
