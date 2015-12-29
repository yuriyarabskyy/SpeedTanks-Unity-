using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	float speed = 75,angle,t=Time.time-1;
	bool flag = false;
	public GameObject bull,place;

	void Update(){
		if (!flag) {
						Vector2 vec = GameObject.FindGameObjectWithTag ("Player").transform.position - transform.position;
						vec = vec / vec.magnitude;
						GetComponent<Rigidbody2D>().velocity = vec * speed * Time.deltaTime;
						if (vec.y > 0)
								angle = Vector3.Angle (new Vector3 (1, 0, 0), vec);
						if (vec.y < 0)
								angle = Vector3.Angle (new Vector3 (-1, 0, 0), vec) + 180;
						transform.rotation = Quaternion.AngleAxis (angle, new Vector3 (0, 0, 1));
						t = Time.time-1.5f;
				}
		if (flag) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
			Vector2 vec = GameObject.FindGameObjectWithTag ("Player").transform.position - transform.position;
			vec = vec / vec.magnitude;
			if (vec.y > 0)
				angle = Vector3.Angle (new Vector3 (1, 0, 0), vec);
			if (vec.y < 0)
				angle = Vector3.Angle (new Vector3 (-1, 0, 0), vec) + 180;
			transform.rotation = Quaternion.AngleAxis (angle, new Vector3 (0, 0, 1));
			if (Time.time > t + 2) {
				t = Time.time;
				GameObject bullet = Instantiate(bull, place.transform.position, Quaternion.AngleAxis(angle,new Vector3(0,0,1))) as GameObject;
				bullet.GetComponent<Rigidbody2D>().AddForce(place.transform.right*150) ;
			}

				}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player")
						flag = true;
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player")
			flag = false;
	}
}
