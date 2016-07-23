using UnityEngine;
using System.Collections;

public class Damager : MonoBehaviour {
	public bool shouldIDamage;
	//We could play a sound while damage is outputed as a means to know when to damage again. 
	void OnTriggerEnter2D(Collider2D player){
		if (player.GetComponent<HealthManager> () != null) {
			player.GetComponent<HealthManager> ().DamageDone (10);
		} else if (player.GetComponent<MoveBullet> () != null) {
			Destroy (player.gameObject);
		}
	}

	void OnTriggerStay2D(Collider2D player){
		if (player.GetComponent<HealthManager> () != null) {
			player.GetComponent<HealthManager> ().DamageDone (1);
		}
	}
}
