using UnityEngine;
using System.Collections;

public class lifebonus : MonoBehaviour {
	public GameObject life11,life12,life21,life22,shield1,shield2;
	bool flag = false;


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			if(other.name=="Player1"){
				if(GameObject.FindGameObjectWithTag ("Life22")==null){
					Instantiate(life12);
					flag = true;
				}
				if(GameObject.FindGameObjectWithTag("Life21")==null&&!flag){
					Instantiate(life11);
					flag = true;
				}
				if(GameObject.Find("Shield1")==null&&!flag){
					Instantiate(shield1);
				}
			}		
		}

		if (other.tag == "Player") {
			if(other.name=="Player2"){
				if(GameObject.FindGameObjectWithTag ("Life12")==null){
					Instantiate(life22);
					flag = true;
				}
				if(GameObject.FindGameObjectWithTag("Life11")==null&&!flag){
					Instantiate(life21);
					flag = true;
				}
				if(GameObject.Find("Shield2")==null&&!flag){
					Instantiate(shield2);
				}
			}		
		}

		if(other.tag=="Player")
		Destroy (gameObject);
	}
}
