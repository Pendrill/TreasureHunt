using UnityEngine;
using System.Collections;

public class IgnorePills : MonoBehaviour {

	void OnTriggerEnter2D( Collider2D player){
		if (player.GetComponent<HealthManager> ().getHealth () >= 75) {
			player.GetComponent<StabilityManager> ().loseStability (5);
		} else if (player.GetComponent<HealthManager> ().getHealth () >= 50) {
			player.GetComponent<StabilityManager> ().loseStability (15);
		} else if (player.GetComponent<HealthManager> ().getHealth () >= 25) {
			player.GetComponent<StabilityManager> ().loseStability (25);
		} else {
			player.GetComponent<StabilityManager> ().loseStability (30);
		}

	}
}
