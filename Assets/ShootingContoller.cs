using UnityEngine;
using System.Collections;

public class ShootingContoller : MonoBehaviour {

	public GameObject player,col,bull,place,cam,reloader,bulle,rel,tank;
		Vector3 start_pos;
		bool undetected = true;
		int finger,bulletsleft;
		Vector3 pos;
		Vector2 vec;
		float angle,t;
	int fingerid;
	bool stop = false;
		
		void Start(){
			start_pos = col.transform.position;
			t = -1000;
		bulletsleft = 10; 
		bulle.GetComponent<Renderer>().sortingOrder= 1;
		reloader.GetComponent<Renderer>().material.color = new Color(0,0,0,0.5f);
		rel.GetComponent<Renderer>().material.color = new Color(0,0,0,1);
		rel.GetComponent<Renderer>().sortingOrder = 4;
		}
		
		void Update(){
		int i = 0;
			pos = transform.position;
		start_pos = col.transform.position;
		bulle.GetComponent<TextMesh> ().text = bulletsleft.ToString ();


		while (i<Input.touchCount&&undetected) {
			if (Input.GetTouch(i).phase==TouchPhase.Began && col.GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint (Input.GetTouch (i).position))) {
				undetected = false;	
				finger = i;
				fingerid = Input.GetTouch(i).fingerId;
			}
			if (reloader.GetComponent<Collider2D>().OverlapPoint (cam.GetComponent<Camera>().ScreenToWorldPoint(Input.GetTouch(i).position))
			    && Input.GetTouch(i).phase == TouchPhase.Ended) {
				stop = true;
				reloader.GetComponent<Renderer>().material.color = new Color(0,0,0,0);
				rel.GetComponent<Renderer>().material.color = new Color(0,0,0,0);
				StartCoroutine("reload");
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
		if (undetected) {
			player.transform.eulerAngles = new Vector3(0,0,tank.transform.eulerAngles.z+180);  
		}
		if(player.name=="PivotPoint")
		if (!undetected && Time.time > t + 0.4f&&((bulletsleft>0&&!stop)||GameObject.FindGameObjectWithTag("shooting1")!=null)) {
			t = Time.time;
			GameObject bullet = Instantiate(bull, place.transform.position, Quaternion.AngleAxis(angle,new Vector3(0,0,1))) as GameObject;
			GetComponent<AudioSource>().Play();
			bullet.GetComponent<Rigidbody2D>().AddForce(place.transform.right*350) ;
			if(GameObject.FindGameObjectWithTag("shooting1")==null)
				bulletsleft -= 1;
		}
		if(player.name=="PivotPont")
		if (!undetected && Time.time > t + 0.4f&&((bulletsleft>0&&!stop)||GameObject.FindGameObjectWithTag("shooting2")!=null)) {
			t = Time.time;
			GameObject bullet = Instantiate(bull, place.transform.position, Quaternion.AngleAxis(angle,new Vector3(0,0,1))) as GameObject;
			GetComponent<AudioSource>().Play();
			bullet.GetComponent<Rigidbody2D>().AddForce(place.transform.right*350) ;
			if(GameObject.FindGameObjectWithTag("shooting2")==null)
				bulletsleft -= 1;
		}
			
		}
	IEnumerator reload(){
		yield return new WaitForSeconds (2);
		bulletsleft = 10;
		reloader.GetComponent<Renderer>().material.color = new Color(0,0,0,0.5f);
		rel.GetComponent<Renderer>().material.color = new Color(0,0,0,1);
		stop = false;
	}
	}
	
	