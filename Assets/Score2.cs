using UnityEngine;
using System.Collections;

public class Score2 : MonoBehaviour {
	
	bool flag = false;
	
	void Start(){
		GetComponent<TextMesh> ().text = PlayerPrefs.GetInt ("score2").ToString();
		GetComponent<Renderer>().sortingOrder = 6;
	}
	void Update(){
		if (GameObject.Find ("Player1") == null && !flag) {
			PlayerPrefs.SetInt("score2",PlayerPrefs.GetInt("score2")+1);
			GetComponent<TextMesh> ().text = PlayerPrefs.GetInt ("score2").ToString();
			flag = true;
		}
	}
}
