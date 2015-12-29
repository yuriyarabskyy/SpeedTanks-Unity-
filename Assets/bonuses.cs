using UnityEngine;
using System.Collections;

public class bonuses : MonoBehaviour {
	public GameObject[] bonuser;
	void Start(){
		StartCoroutine (bonus());
	}

	IEnumerator bonus(){
		int rand = Random.Range (0, bonuser.Length);
		Instantiate (bonuser[rand], new Vector3 (0, 0, 0), Quaternion.identity);
		int time = 10;
		while(GameObject.FindGameObjectsWithTag("Player").Length==2){
			yield return new WaitForSeconds(0.1f);
			if(GameObject.FindGameObjectsWithTag("hp").Length==0&&GameObject.FindGameObjectsWithTag("speeder").Length==0
			   &&GameObject.FindGameObjectsWithTag("shooter").Length==0){
				yield return new WaitForSeconds(time);
				rand = Random.Range(0,bonuser.Length);
				Instantiate (bonuser[rand], new Vector3 (0, 0, 0), Quaternion.identity);

			}
		}
	}
}
