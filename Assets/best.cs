using UnityEngine;
using System.Collections;

public class best : MonoBehaviour {

	void Start(){
		GetComponent<TextMesh> ().text = PlayerPrefs.GetInt ("Best").ToString ();
	}
}
