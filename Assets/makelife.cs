using UnityEngine;
using System.Collections;

public class makelife : MonoBehaviour {
	public GameObject l11,l12,l13,l21,l22,l23;
	bool flag=false;
	void Start(){
		StartCoroutine (maker ());
	}
	IEnumerator maker(){
		while(GameObject.FindGameObjectsWithTag("Player").Length==2){
			flag = false;
		yield return new WaitForSeconds (5);
		if (GameObject.Find ("PivotPoint").transform.position == transform.position) {
			if(GameObject.FindGameObjectWithTag("Life23")==null&&!flag){
				Instantiate(l13);
					flag = true;
			}
			if(GameObject.FindGameObjectWithTag("Life22")==null&&!flag){
				Instantiate(l12);
					flag = true;
			}
			if(GameObject.FindGameObjectWithTag("Life21")==null&&!flag){
				Instantiate(l11);
					flag = true;
			}
				if(GameObject.FindGameObjectWithTag("Life11")!=null&&!flag){
					Destroy(GameObject.FindGameObjectWithTag("Life11"));
					flag = true;
				}
				if(GameObject.FindGameObjectWithTag("Life12")!=null&&!flag){
					Destroy(GameObject.FindGameObjectWithTag("Life12"));
					flag = true;
				}
				if(GameObject.FindGameObjectWithTag("Life13")!=null&&!flag){
					Destroy(GameObject.FindGameObjectWithTag("Life13"));
					Destroy(GameObject.Find("Player2"));
					flag = true;
				}
				if(GameObject.FindGameObjectWithTag("Life13")==null&&!flag){
					Destroy(GameObject.Find("Player2"));
					flag = true;
				}

				}
					        if (GameObject.Find ("PivotPont").transform.position == transform.position) {
						if(GameObject.FindGameObjectWithTag("Life13")==null&&!flag){
							Instantiate(l23);
							flag = true;
						}
						if(GameObject.FindGameObjectWithTag("Life12")==null&&!flag){
							Instantiate(l22);
							flag = true;
						}
						if(GameObject.FindGameObjectWithTag("Life11")==null&&!flag){
							Instantiate(l21);
							flag = true;
						}
						if(GameObject.FindGameObjectWithTag("Life21")!=null&&!flag){
							Destroy(GameObject.FindGameObjectWithTag("Life21"));
							flag = true;
						}
						if(GameObject.FindGameObjectWithTag("Life22")!=null&&!flag){
							Destroy(GameObject.FindGameObjectWithTag("Life22"));
							flag = true;
						}
						if(GameObject.FindGameObjectWithTag("Life23")!=null&&!flag){
					Destroy(GameObject.FindGameObjectWithTag("Life23"));
							Destroy(GameObject.Find("Player1"));
							        flag = true;
							        }
				if(GameObject.FindGameObjectWithTag("Life23")==null&&!flag){
					Destroy(GameObject.Find("Player1"));
					flag = true;
				}
							        
							        }
	}
}
}
