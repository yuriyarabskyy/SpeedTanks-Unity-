using UnityEngine;
using System.Collections;

public class bonuses3 : MonoBehaviour {
	public GameObject hp;
	int i;
	
	void Start(){
		StartCoroutine (bonus());
	}
	
	IEnumerator bonus(){
		i = Random.Range(0,8);
		if(i==1)
			Instantiate (hp, new Vector3 (3.49f, 0.61f, 0), Quaternion.identity);
		if(i==2)
			Instantiate (hp, new Vector3 (9.31f, 9.85f, 0), Quaternion.identity);
		if(i==3)
			Instantiate (hp, new Vector3 (6.91f, -8.847f, 0), Quaternion.identity);
		if(i==4)
			Instantiate (hp, new Vector3 (-13.45f, 9.667f, 0), Quaternion.identity);
		if(i==5)
			Instantiate (hp, new Vector3 (-13.22f, -9.4f, 0), Quaternion.identity);
		if(i==6)
			Instantiate (hp, new Vector3 (0.63f, 8.929f, 0), Quaternion.identity);
		if(i==7)
			Instantiate (hp, new Vector3 (-1.77f, 0.71f, 0), Quaternion.identity);
		int time = 10;
		while(GameObject.FindGameObjectsWithTag("Player").Length==2){
			yield return new WaitForSeconds(0.1f);
			if(GameObject.FindGameObjectsWithTag("hp").Length==0){
				yield return new WaitForSeconds(time);
				i = Random.Range(0,8);
				if(i==1)
					Instantiate (hp, new Vector3 (3.49f, 0.61f, 0), Quaternion.identity);
				if(i==2)
					Instantiate (hp, new Vector3 (9.31f, 9.85f, 0), Quaternion.identity);
				if(i==3)
					Instantiate (hp, new Vector3 (6.91f, -8.847f, 0), Quaternion.identity);
				if(i==4)
					Instantiate (hp, new Vector3 (-13.45f, 9.667f, 0), Quaternion.identity);
				if(i==5)
					Instantiate (hp, new Vector3 (-13.22f, -9.4f, 0), Quaternion.identity);
				if(i==6)
					Instantiate (hp, new Vector3 (0.63f, 8.929f, 0), Quaternion.identity);
				if(i==7)
					Instantiate (hp, new Vector3 (-1.77f, 0.71f, 0), Quaternion.identity);
				time+=2;
			}
		}
	}
}
