using UnityEngine;
using System.Collections;

public class SC1 : MonoBehaviour {
	
	public GameObject player,col,bull,place,cam,tank;
	Vector3 start_pos;
	bool undetected = true;
	int finger;
	Vector3 pos;
	Vector2 vec;
	float angle,t;
	int fingerid;
	
	void Start(){
		start_pos = col.transform.position;
		t = -1000;

	}
	
	void Update(){
		int i = 0;
		pos = transform.position;
		start_pos = col.transform.position;

		
		
		while (i<Input.touchCount&&undetected) {
			if (Input.GetTouch(i).phase==TouchPhase.Began && col.GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position))) {
				undetected = false;	
				finger = i;
				fingerid = Input.GetTouch(i).fingerId;
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
		
		if (!undetected && Input.GetTouch(finger).phase==TouchPhase.Ended) {
			undetected = true;
			
		}
		if (undetected&&transform.position!=start_pos) {
			transform.position = Vector2.MoveTowards(transform.position, start_pos,Time.deltaTime*10);
		}
		if (!undetected) {
			transform.position = new Vector3(cam.GetComponent<Camera>().ScreenToWorldPoint(Input.GetTouch(finger).position).x,cam.GetComponent<Camera>().ScreenToWorldPoint(Input.GetTouch(finger).position).y,0);
			if ((transform.position - start_pos).magnitude >0.41f) {
				transform.position = new Vector3((transform.position.x-start_pos.x)/(transform.position-start_pos).magnitude*0.41f+start_pos.x,(transform.position.y-start_pos.y)/(transform.position-start_pos).magnitude*0.41f+start_pos.y,0);
			}
			
		}
		if(transform.position.y-start_pos.y>0)
			angle = Vector3.Angle(new Vector3(1,0,0),transform.position-start_pos);
		if(transform.position.y-start_pos.y<0)
			angle = Vector3.Angle(new Vector3(-1,0,0),transform.position-start_pos)+180;
		if(angle!=0)
			player.transform.rotation = Quaternion.AngleAxis (angle,new Vector3(0,0,1));
		if (transform.position.x - start_pos.x == 0 && transform.position.y - start_pos.y == 0) {
			player.transform.eulerAngles = new Vector3(0,0,tank.transform.eulerAngles.z+180);  
		}
		if (!undetected && Time.time > t + 0.4f) {
			t = Time.time;
			GameObject bullet = Instantiate(bull, place.transform.position, Quaternion.AngleAxis(angle,new Vector3(0,0,1))) as GameObject;
			GetComponent<AudioSource>().Play ();
			bullet.GetComponent<Rigidbody2D>().AddForce(place.transform.right*250) ;
		}
		
	}

}
