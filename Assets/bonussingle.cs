using UnityEngine;
using System.Collections;

public class bonussingle : MonoBehaviour {

	public GameObject[] bonuser;
	float x,y;
	void Start(){
		StartCoroutine (bonus());
	}
	IEnumerator bonus(){
		int time = 20;
		while(GameObject.FindGameObjectsWithTag("Player").Length==1){
			yield return new WaitForSeconds(0.1f);
			if(GameObject.FindGameObjectsWithTag("hp").Length==0&&GameObject.FindGameObjectsWithTag("speeder").Length==0
			   &&GameObject.FindGameObjectsWithTag("shooter").Length==0){
				yield return new WaitForSeconds(time);
				int rand;
				rand = Random.Range (0, bonuser.Length);
				x=Random.Range(-6,6);
				y=Random.Range(-4.5f,4.5f);
				Instantiate(bonuser[rand],new Vector3(x,y,0),Quaternion.identity);
			}
		}
	}
}
