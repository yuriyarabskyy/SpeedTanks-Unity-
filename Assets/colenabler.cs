using UnityEngine;
using System.Collections;

public class colenabler : MonoBehaviour {

	void Update(){
		if (GetComponent<Renderer>().GetComponent<SpriteRenderer>().color.a < 1)
						GetComponent<Collider2D>().enabled = false;
		if (GetComponent<Renderer>().GetComponent<SpriteRenderer>().color.a == 1)
			GetComponent<Collider2D>().enabled = true;
	}
}
