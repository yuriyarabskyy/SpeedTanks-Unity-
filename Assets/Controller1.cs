

using UnityEngine;
using System.Collections;

public class Controller1 : MonoBehaviour {
	public GameObject player,col,cam;
	Vector3 start_pos;
	bool undetected = true;
	int finger;
	Vector3 pos;
	Vector2 vec,vel;
	int fingerid;
	float angle,speed;
	float destroytime1=0,destroytime2=0;
	bool flag=true;
	bool flag2 = true;
	
	void Start(){
		start_pos = col.transform.position;
	}
	
	void Update(){
		int i = 0;
		pos = transform.position;
		vel = player.GetComponent<Rigidbody2D>().velocity;
		start_pos = col.transform.position;
		

		while (i<Input.touchCount&&undetected) {
			if (Input.GetTouch (i).phase == TouchPhase.Began && col.GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.GetTouch (i).position))) {
				undetected = false;
				fingerid = Input.GetTouch(i).fingerId;
				finger = i;
			}
			i++;
			
		}

		int k = 0;
		if (!undetected) {
			while(k<Input.touchCount)
			{
				if(fingerid==Input.GetTouch(k).fingerId)
					finger = k;
				k++;
			}
		}
		
		if (!undetected && Input.GetTouch (finger).phase == TouchPhase.Ended) {
			undetected = true;
			
		}
		if (undetected&&transform.position!=start_pos) {
			transform.position = Vector2.MoveTowards(transform.position, start_pos,Time.deltaTime*10);
		}
		if (!undetected) {
			transform.position = new Vector3(cam.GetComponent<Camera>().ScreenToWorldPoint(Input.GetTouch(finger).position).x,cam.GetComponent<Camera>().ScreenToWorldPoint(Input.GetTouch(finger).position).y,0);
			if ((transform.position - start_pos).magnitude >0.78f) {
				transform.position = new Vector3((transform.position.x-start_pos.x)/(transform.position-start_pos).magnitude*0.78f+start_pos.x,(transform.position.y-start_pos.y)/(transform.position-start_pos).magnitude*0.78f+start_pos.y,0);
			}
			
		}
		if(transform.position.y-start_pos.y>0)
			angle = Vector3.Angle(new Vector3(1,0,0),transform.position-start_pos);
		if(transform.position.y-start_pos.y<0)
			angle = Vector3.Angle(new Vector3(-1,0,0),transform.position-start_pos)+180;
		if(angle!=0)
			player.transform.rotation = Quaternion.AngleAxis (angle+180,new Vector3(0,0,1));
		vec = transform.position-start_pos;
		if (GameObject.FindGameObjectWithTag ("speeding2") == null&&player.name=="Player2") 
			speed = 4;
		if (GameObject.FindGameObjectWithTag ("speeding1") == null&&player.name=="Player1") 
			speed = 4;
		if (GameObject.FindGameObjectWithTag ("speeding2") != null&&player.name=="Player2") 
			speed = 6;
		if (GameObject.FindGameObjectWithTag ("speeding1") != null&&player.name=="Player1") 
			speed = 6;
		player.GetComponent<Rigidbody2D>().velocity = vec*speed;
		
		
	}
}





