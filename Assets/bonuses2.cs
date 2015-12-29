using UnityEngine;
using System.Collections;

public class bonuses2 : MonoBehaviour {
	public GameObject[] bonuser;
	float x,y;
	int i,k;

	void Start(){
		StartCoroutine (bonus());
	}
	
	IEnumerator bonus(){
		i = Random.Range(-1,2);
		k = Random.Range(-1,2);
		if(i==-1)
			x = -5.7f;
		if(i==1)
			x = 5.7f;
		if(i==0)
			x = 0;
		if(k==-1)
			y = -4.5f;
		if(k==1)
			y = 4.5f;
		if(k==0)
			y = 0;
		int rand = Random.Range (0, bonuser.Length);
		Instantiate (bonuser[rand], new Vector3 (x, y, 0), Quaternion.identity);
		int time = 10;
		while(GameObject.FindGameObjectsWithTag("Player").Length==2){
			yield return new WaitForSeconds(0.1f);
			if(GameObject.FindGameObjectsWithTag("hp").Length==0&&GameObject.FindGameObjectsWithTag("speeder").Length==0
			   &&GameObject.FindGameObjectsWithTag("shooter").Length==0){
				yield return new WaitForSeconds(time);
				i = Random.Range(-1,2);
				k = Random.Range(-1,2);
				if(i==-1)
					x = -5.7f;
				if(i==1)
					x = 5.7f;
				if(i==0)
					x = 0;
				if(k==-1)
					y = -4.5f;
				if(k==1)
					y = 4.5f;
				if(k==0)
					y = 0;
				rand = Random.Range (0, bonuser.Length);
				Instantiate (bonuser[rand], new Vector3 (x, y, 0), Quaternion.identity);

			}
		}
	}
}

