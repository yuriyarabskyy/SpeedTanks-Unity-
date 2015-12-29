using UnityEngine;
using System.Collections;

public class demolisher : MonoBehaviour {
	void OnColliderEnter2D(){
		Destroy (gameObject);
	}
}
