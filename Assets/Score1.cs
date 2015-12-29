using UnityEngine;
using System.Collections;

public class Score1 : MonoBehaviour {

	bool flag = false;

	void Start(){
		GetComponent<TextMesh> ().text = PlayerPrefs.GetInt ("score1").ToString();
		GetComponent<Renderer>().sortingOrder = 6;
	}
	void Update(){
		if (GameObject.Find ("Player2") == null && !flag) {
			PlayerPrefs.SetInt("score1",PlayerPrefs.GetInt("score1")+1);
			GetComponent<TextMesh> ().text = PlayerPrefs.GetInt ("score1").ToString();
			flag = true;
		}
	}
}
