using UnityEngine;
using System.Collections;

public class musicinst : MonoBehaviour {
	public GameObject music;
	void Awake(){
		if (GameObject.FindGameObjectWithTag ("MenuMusic") == null)
						Instantiate (music);
	}
}
