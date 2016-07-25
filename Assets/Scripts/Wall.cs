using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D bullet){
		if (bullet.gameObject.GetComponent<MoveBullet> () != null) {
			Destroy (bullet.gameObject);
		}
	}
}
