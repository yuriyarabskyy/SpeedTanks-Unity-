using UnityEngine;
using System.Collections;

public class scorer : MonoBehaviour {
	int score;

	void Awake(){
		if(!PlayerPrefs.HasKey("Best"))
			PlayerPrefs.SetInt("Best",0);
		Application.targetFrameRate = 60;
	}

	void Update(){
		if(GameObject.FindGameObjectWithTag("Player")!=null){
		GetComponent<TextMesh> ().text = ((int)Time.timeSinceLevelLoad).ToString ();
			score = (int)Time.timeSinceLevelLoad;
		}
		if (GameObject.FindGameObjectWithTag ("Player") == null) {
			if(PlayerPrefs.GetInt("Best")<score)
				PlayerPrefs.SetInt("Best",score);
				}
	}
}
