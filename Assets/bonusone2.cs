using System.Collections;
using UnityEngine;

public class bonusone2 : MonoBehaviour {
	public GameObject[] bonuser;
	int i;
	
	void Start(){
		StartCoroutine (bonus());
	}
	
	IEnumerator bonus(){
		i = Random.Range(1,5);
		int rand = Random.Range (0, bonuser.Length);
		if(i==1)
			Instantiate (bonuser[rand], new Vector3 (2, 2, 0), Quaternion.identity);
		if(i==2)
			Instantiate (bonuser[rand], new Vector3 (2, -2, 0), Quaternion.identity);
		if(i==3)
			Instantiate (bonuser[rand], new Vector3 (-2, 2, 0), Quaternion.identity);
		if(i==4)
			Instantiate (bonuser[rand], new Vector3 (-2, -2, 0), Quaternion.identity);
		int time = 10;
		while(GameObject.FindGameObjectsWithTag("Player").Length==2){
			yield return new WaitForSeconds(0.1f);
			if(GameObject.FindGameObjectsWithTag("hp").Length==0&&GameObject.FindGameObjectsWithTag("speeder").Length==0
			   &&GameObject.FindGameObjectsWithTag("shooter").Length==0){
				yield return new WaitForSeconds(time);
				i = Random.Range(1,5);
				rand = Random.Range (0, bonuser.Length);
				if(i==1)
					Instantiate (bonuser[rand], new Vector3 (2, 2, 0), Quaternion.identity);
				if(i==2)
					Instantiate (bonuser[rand], new Vector3 (2, -2, 0), Quaternion.identity);
				if(i==3)
					Instantiate (bonuser[rand], new Vector3 (-2, 2, 0), Quaternion.identity);
				if(i==4)
					Instantiate (bonuser[rand], new Vector3 (-2, -2, 0), Quaternion.identity);
				
			}
		}
	}
}