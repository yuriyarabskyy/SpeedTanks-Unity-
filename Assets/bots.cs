using UnityEngine;
using System.Collections;

public class bots : MonoBehaviour {
	public GameObject bot;
	float t=5;
	float x,y;
	void Start(){
		StartCoroutine (boten ());
	}

	IEnumerator boten(){
		yield return new WaitForSeconds(t);
				while (GameObject.FindGameObjectWithTag("Player")!=null) {
			int i = Random.Range(0,3);
			if(i==0){
						 x = Random.Range (5.5f, 6.25f);
						 y = Random.Range (-4.6f, 4.2f);
			}
			if(i==1){
				 x = Random.Range (-5.5f, -6.25f);
				 y = Random.Range (-4.6f, 4.2f);
			}
			if(i==2){
				 x = Random.Range (-6.25f, 6.25f);
				 y = Random.Range (3.5f, 4.2f);
			}
						Instantiate (bot, new Vector3 (x, y, 0), Quaternion.identity);
			yield return new WaitForSeconds(t);
			if(t>1)
				t -= 0.2f;
			if(t==1&&Time.timeScale<4)
			Time.timeScale += 0.1f;
				}
		Time.timeScale = 1;
		}
}
