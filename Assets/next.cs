using UnityEngine;
using System.Collections;

public class next : MonoBehaviour {

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
						Application.LoadLevel("level2");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10");}
					if(!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1");}

				}
				if(PlayerPrefs.GetInt("scene2")==2&&!flag){
					PlayerPrefs.SetInt("scene2",1);
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1");}
					if(!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2");}

		}
				if(PlayerPrefs.GetInt("scene3")==2&&!flag){
					PlayerPrefs.SetInt("scene3",1);

					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2");}
					if(!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3");}
				}
				if(PlayerPrefs.GetInt("scene4")==2&&!flag){
					PlayerPrefs.SetInt("scene4",1);
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3");}
					if(!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4");}
				}
				if(PlayerPrefs.GetInt("scene5")==2&&!flag){
					PlayerPrefs.SetInt("scene5",1);
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4");}
					if(!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5");}

				}
				if(PlayerPrefs.GetInt("scene6")==2&&!flag){
					PlayerPrefs.SetInt("scene6",1);
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5");}
					if(!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6");}
				}
				if(PlayerPrefs.GetInt("scene7")==2&&!flag){
					PlayerPrefs.SetInt("scene7",1);
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6");}
					if(!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7");}
				}
				if(PlayerPrefs.GetInt("scene8")==2&&!flag){
					PlayerPrefs.SetInt("scene8",1);
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9");}
					if(PlayerPrefs.GetInt("scene10")==1&&!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10");}
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7");}
				if(!flag){
					PlayerPrefs.SetInt("scene8",2);
					flag = true;
					Application.LoadLevel("level8");}
				}
			if(PlayerPrefs.GetInt("scene9")==2&&!flag){
				PlayerPrefs.SetInt("scene9",1);
				if(PlayerPrefs.GetInt("scene10")==1&&!flag){
					PlayerPrefs.SetInt("scene10",2);
					flag = true;
					Application.LoadLevel("level10");}
				if(PlayerPrefs.GetInt("scene1")==1&&!flag){
					PlayerPrefs.SetInt("scene1",2);
					flag = true;
					Application.LoadLevel("level1");}
				if(PlayerPrefs.GetInt("scene2")==1&&!flag){
					PlayerPrefs.SetInt("scene2",2);
					flag = true;
					Application.LoadLevel("level2");}
				if(PlayerPrefs.GetInt("scene3")==1&&!flag){
					PlayerPrefs.SetInt("scene3",2);
					flag = true;
					Application.LoadLevel("level3");}
				if(PlayerPrefs.GetInt("scene4")==1&&!flag){
					PlayerPrefs.SetInt("scene4",2);
					flag = true;
					Application.LoadLevel("level4");}
				if(PlayerPrefs.GetInt("scene5")==1&&!flag){
					PlayerPrefs.SetInt("scene5",2);
					flag = true;
					Application.LoadLevel("level5");}
				if(PlayerPrefs.GetInt("scene6")==1&&!flag){
					PlayerPrefs.SetInt("scene6",2);
					flag = true;
					Application.LoadLevel("level6");}
				if(PlayerPrefs.GetInt("scene7")==1&&!flag){
					PlayerPrefs.SetInt("scene7",2);
					flag = true;
					Application.LoadLevel("level7");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8");}
			if(!flag){
				PlayerPrefs.SetInt("scene9",2);
				flag = true;
				Application.LoadLevel("level9");}
		}
				if(PlayerPrefs.GetInt("scene10")==2&&!flag){
					PlayerPrefs.SetInt("scene10",1);
					if(PlayerPrefs.GetInt("scene1")==1&&!flag){
						PlayerPrefs.SetInt("scene1",2);
						flag = true;
						Application.LoadLevel("level1");}
					if(PlayerPrefs.GetInt("scene2")==1&&!flag){
						PlayerPrefs.SetInt("scene2",2);
						flag = true;
						Application.LoadLevel("level2");}
					if(PlayerPrefs.GetInt("scene3")==1&&!flag){
						PlayerPrefs.SetInt("scene3",2);
						flag = true;
						Application.LoadLevel("level3");}
					if(PlayerPrefs.GetInt("scene4")==1&&!flag){
						PlayerPrefs.SetInt("scene4",2);
						flag = true;
						Application.LoadLevel("level4");}
					if(PlayerPrefs.GetInt("scene5")==1&&!flag){
						PlayerPrefs.SetInt("scene5",2);
						flag = true;
						Application.LoadLevel("level5");}
					if(PlayerPrefs.GetInt("scene6")==1&&!flag){
						PlayerPrefs.SetInt("scene6",2);
						flag = true;
						Application.LoadLevel("level6");}
					if(PlayerPrefs.GetInt("scene7")==1&&!flag){
						PlayerPrefs.SetInt("scene7",2);
						flag = true;
						Application.LoadLevel("level7");}
					if(PlayerPrefs.GetInt("scene8")==1&&!flag){
						PlayerPrefs.SetInt("scene8",2);
						flag = true;
						Application.LoadLevel("level8");}
					if(PlayerPrefs.GetInt("scene9")==1&&!flag){
						PlayerPrefs.SetInt("scene9",2);
						flag = true;
						Application.LoadLevel("level9");}
					if(!flag){
						PlayerPrefs.SetInt("scene10",2);
						flag = true;
						Application.LoadLevel("level10");}
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
