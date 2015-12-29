using UnityEngine;
using System.Collections;

public class bonus6 : MonoBehaviour {
	public GameObject[] bonuser;
	int i;
	
	void Start(){
		StartCoroutine (bonus());
	}
	
	IEnumerator bonus(){
		i = Random.Range(1,13);
		int rand = Random.Range (0, bonuser.Length);
		if(i==1)
			Instantiate (bonuser[rand], new Vector3 (-4.5f, 0f, 0), Quaternion.identity);
		if(i==2)
			Instantiate (bonuser[rand], new Vector3 (4.5f, 0, 0), Quaternion.identity);
		if(i==3)
			Instantiate (bonuser[rand], new Vector3 (4.5f, 4.5f, 0), Quaternion.identity);
		if(i==4)
			Instantiate (bonuser[rand], new Vector3 (-4.5f, 4.5f, 0), Quaternion.identity);
		if(i==5)
			Instantiate (bonuser[rand], new Vector3 (4.5f, -4.5f, 0), Quaternion.identity);
		if(i==6)
			Instantiate (bonuser[rand], new Vector3 (0, 4.5f, 0), Quaternion.identity);
		if(i==7)
			Instantiate (bonuser[rand], new Vector3 (0, -4.5f, 0), Quaternion.identity);
		if(i==8)
			Instantiate (bonuser[rand], new Vector3 (-4.5f, -4.5f, 0), Quaternion.identity);
		if(i==9)
			Instantiate (bonuser[rand], new Vector3 (1.5f, 0, 0), Quaternion.identity);
		if(i==10)
			Instantiate (bonuser[rand], new Vector3 (-1.5f, 0, 0), Quaternion.identity);
		if(i==11)
			Instantiate (bonuser[rand], new Vector3 (0, -1.5f, 0), Quaternion.identity);
		if(i==12)
			Instantiate (bonuser[rand], new Vector3 (0, 1.5f, 0), Quaternion.identity);
		int time = 10;
		while(GameObject.FindGameObjectsWithTag("Player").Length==2){
			yield return new WaitForSeconds(0.1f);
			if(GameObject.FindGameObjectsWithTag("hp").Length==0&&GameObject.FindGameObjectsWithTag("speeder").Length==0
			   &&GameObject.FindGameObjectsWithTag("shooter").Length==0){
				yield return new WaitForSeconds(time);
				i = Random.Range(1,13);
				rand = Random.Range (0, bonuser.Length);
				if(i==1)
					Instantiate (bonuser[rand], new Vector3 (-4.5f, 0f, 0), Quaternion.identity);
				if(i==2)
					Instantiate (bonuser[rand], new Vector3 (4.5f, 0, 0), Quaternion.identity);
				if(i==3)
					Instantiate (bonuser[rand], new Vector3 (4.5f, 4.5f, 0), Quaternion.identity);
				if(i==4)
					Instantiate (bonuser[rand], new Vector3 (-4.5f, 4.5f, 0), Quaternion.identity);
				if(i==5)
					Instantiate (bonuser[rand], new Vector3 (4.5f, -4.5f, 0), Quaternion.identity);
				if(i==6)
					Instantiate (bonuser[rand], new Vector3 (0, 4.5f, 0), Quaternion.identity);
				if(i==7)
					Instantiate (bonuser[rand], new Vector3 (0, -4.5f, 0), Quaternion.identity);
				if(i==8)
					Instantiate (bonuser[rand], new Vector3 (-4.5f, -4.5f, 0), Quaternion.identity);
				if(i==9)
					Instantiate (bonuser[rand], new Vector3 (1.5f, 0, 0), Quaternion.identity);
				if(i==10)
					Instantiate (bonuser[rand], new Vector3 (-1.5f, 0, 0), Quaternion.identity);
				if(i==11)
					Instantiate (bonuser[rand], new Vector3 (0, -1.5f, 0), Quaternion.identity);
				if(i==12)
					Instantiate (bonuser[rand], new Vector3 (0, 1.5f, 0), Quaternion.identity);
			}
		}
	}
}