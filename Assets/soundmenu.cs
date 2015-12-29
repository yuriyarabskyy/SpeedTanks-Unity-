using UnityEngine;
using System.Collections;

public class soundmenu : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	void Update(){
		if (GameObject.FindGameObjectWithTag ("Player") != null)
						Destroy (gameObject);
	}
}
