using UnityEngine;
using System.Collections;

public class nextlevela : MonoBehaviour {
	
	public GameObject cam;
	
	void Start(){
		GetComponent<Renderer>().sortingOrder = 7;
	}
	
	void Update(){
		int i = 0;
		while (i<Input.touchCount) {
			if (GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position))
			    && Input.GetTouch (i).phase == TouchPhase.Ended&&GetComponent<TextMesh>().color.a==1){
				bool flag=false;
				if(PlayerPrefs.GetInt("scene1")==2){
					PlayerPrefs.SetInt("scene1",1);
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2a");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3a");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4a");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5a");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6a");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7a");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8a");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9a");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10a");}
					if(!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1a");}
					
				}
				if(PlayerPrefs.GetInt("scene2")==2&&!flag){
					PlayerPrefs.SetInt("scene2",1);
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3a");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4a");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5a");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6a");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7a");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8a");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9a");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10a");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1a");}
					if(!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2a");}
					
				}
				if(PlayerPrefs.GetInt("scene3")==2&&!flag){
					PlayerPrefs.SetInt("scene3",1);
					
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4a");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5a");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6a");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7a");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8a");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9a");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10a");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1a");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2a");}
					if(!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3a");}
				}
				if(PlayerPrefs.GetInt("scene4")==2&&!flag){
					PlayerPrefs.SetInt("scene4",1);
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5a");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6a");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7a");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8a");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9a");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10a");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1a");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2a");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3a");}
					if(!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4a");}
				}
				if(PlayerPrefs.GetInt("scene5")==2&&!flag){
					PlayerPrefs.SetInt("scene5",1);
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6a");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7a");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8a");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9a");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10a");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1a");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2a");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3a");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4a");}
					if(!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5a");}
					
				}
				if(PlayerPrefs.GetInt("scene6")==2&&!flag){
					PlayerPrefs.SetInt("scene6",1);
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7a");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8a");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9a");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10a");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1a");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2a");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3a");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4a");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5a");}
					if(!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6a");}
				}
				if(PlayerPrefs.GetInt("scene7")==2&&!flag){
					PlayerPrefs.SetInt("scene7",1);
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8a");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9a");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10a");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1a");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2a");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3a");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4a");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5a");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6a");}
					if(!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7a");}
				}
				if(PlayerPrefs.GetInt("scene8")==2&&!flag){
					PlayerPrefs.SetInt("scene8",1);
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9a");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10a");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1a");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2a");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3a");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4a");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5a");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6a");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7a");}
					if(!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8a");}
				}
				if(PlayerPrefs.GetInt("scene9")==2&&!flag){
					PlayerPrefs.SetInt("scene9",1);
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10a");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1a");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2a");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3a");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4a");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5a");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6a");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7a");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8a");}
					if(!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9a");}
				}
				if(PlayerPrefs.GetInt("scene10")==2&&!flag){
					PlayerPrefs.SetInt("scene10",1);
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1a");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2a");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3a");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4a");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5a");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6a");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7a");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8a");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9a");}
					if(!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10a");}
				}
			}
			if (GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position))&&GetComponent<TextMesh>().color.a==1)
				GetComponent<Renderer>().material.color = new Color(0,1,0,1);
			if (!GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position))&&GetComponent<TextMesh>().color.a==1)
				GetComponent<Renderer>().material.color = new Color(1,1,1,1);
			i++;
		}
		
	}
}
